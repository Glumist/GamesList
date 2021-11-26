using GamesList.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GamesList.Forms
{
    public partial class FormMain : Form
    {
        GamesCollection _gamesCollection;

        private const string BUNDLE_NONE = "Без набора";
        private const string BUNDLE_ALL = "Все";
        private const string BUNDLE_SUM = "Сводный";

        public FormMain()
        {
            InitializeComponent();

            dgvGroups.AutoGenerateColumns = false;
            dgvGames.AutoGenerateColumns = false;

            ucGame.GameSaved += UcGame_GameSaved;
            ucGame.BundleSelected += UcGame_BundleSelected;
            ucGame.PlatformSelected += UcGame_PlatformSelected;
            ucGame.GenreSelected += UcGame_GenreSelected;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _gamesCollection = GamesCollection.GetInstance();

            tscbGroup.SelectedIndex = 0;
        }

        private void Save()
        {
            if (!_gamesCollection.Save())
                MessageBox.Show("Ошибка при сохранении!");
        }

        private void ColorRow(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
                cell.Style.BackColor = color;
        }

        #region Groups

        private void RefreshGroupTable()
        {
            dgvGroups.Rows.Clear();
            switch (tscbGroup.SelectedIndex)
            {
                case 0: RefreshBundles(); break;
                case 1: RefreshPlatforms(); break;
                case 2: RefreshGenres(); break;
            }

            foreach (DataGridViewRow row in dgvGroups.Rows)
                row.Height = 30;
        }

        private void AddGroupRow(object dataBoundObject)
        {
            DataGridViewRow dGVRow = new DataGridViewRow();
            MultiColorDataGridViewTextBoxCell textCell = new MultiColorDataGridViewTextBoxCell();
            textCell.Value = dataBoundObject.ToString();
            dGVRow.Cells.Add(textCell);
            dGVRow.Tag = dataBoundObject;
            dgvGroups.Rows.Add(dGVRow);
        }

        private void TscbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGroupTable();
        }

        private void tsmiGroupAdd_Click(object sender, EventArgs e)
        {
            switch (tscbGroup.SelectedIndex)
            {
                case 0: AddBundle(); break;
                case 1: AddPlatform(); break;
                case 2: AddGenre(); break;
            }
        }

        private void tsmiGroupEdit_Click(object sender, EventArgs e)
        {
            switch (tscbGroup.SelectedIndex)
            {
                case 0: EditBundle(); break;
                case 1: EditPlatform(); break;
                case 2: EditGenre(); break;
            }
        }

        private void tsmiGroupDelete_Click(object sender, EventArgs e)
        {
            switch (tscbGroup.SelectedIndex)
            {
                case 0: DeleteBundle(); break;
                case 1: DeletePlatform(); break;
                case 2: DeleteGenre(); break;
            }
        }

        #region Bundles

        private void RefreshBundles()
        {
            List<Bundle> bundles = new List<Bundle>(_gamesCollection.Bundles);
            bundles.Add(new Bundle() { Name = BUNDLE_NONE });
            bundles.Add(new Bundle() { Name = BUNDLE_ALL });
            bundles.Insert(0, new Bundle() { Name = BUNDLE_SUM });
            bundles.ForEach(b => AddGroupRow(b));
            //dgvGroups.DataSource = bundles;
            ColorBundlesTable();
        }

        private void AddBundle()
        {
            FormBundle form = new FormBundle();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _gamesCollection.Add(form.EditedBundle);
            Save();
            RefreshGroupTable();
            SelectBundle(form.EditedBundle);
        }

        private void EditBundle()
        {
            Bundle selectedBundle = GetSelectedBundle();
            if (selectedBundle == null || !IsBundleReal(selectedBundle))
                return;

            if (new FormBundle(selectedBundle).ShowDialog() != DialogResult.OK)
                return;

            Save();
            RefreshGroupTable();
            SelectBundle(selectedBundle);
        }

        private void DeleteBundle()
        {
            Bundle selectedBundle = GetSelectedBundle();
            if (selectedBundle == null || !IsBundleReal(selectedBundle))
                return;

            _gamesCollection.Bundles.Remove(selectedBundle);
            Save();
            RefreshGroupTable();
        }

        private Bundle GetSelectedBundle()
        {
            if (dgvGroups.SelectedRows.Count == 0 || dgvGroups.SelectedRows[0].Index == -1)
                return null;

            return dgvGroups.SelectedRows[0].Tag as Bundle;
        }

        private void SelectBundle(Bundle bundle)
        {
            if (tscbGroup.SelectedIndex != 0)
                return;

            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Bundle rowBundle;

                if (row.Tag is Bundle)
                    rowBundle = row.Tag as Bundle;
                else
                    continue;

                if (rowBundle == bundle)
                {
                    row.Selected = true;
                    dgvGroups.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void ColorBundlesTable()
        {
            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Bundle bundle = row.Tag as Bundle;
                List<Game> bundleGames = GetBundleGames(bundle);
                if (bundleGames.Count == 0)
                    continue;
                else if (!bundleGames.Exists(bg => bg.Status != Game.GamePlatform.GameStatus.Skipped))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Skipped));
                else if (bundleGames.Exists(bg => bg.Status == Game.GamePlatform.GameStatus.Playing))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Playing));
                else if (bundleGames.Exists(bg => bg.Status == Game.GamePlatform.GameStatus.OnHold))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.OnHold));
                else
                {
                    List<Game> nextGames = _gamesCollection.GetNextGamesInBundle(bundle);
                    if (nextGames.Count == 0)
                    {
                        if (bundleGames.Exists(bg => bg.Status == Game.GamePlatform.GameStatus.WaitTranslation))
                            ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.WaitTranslation));
                        else
                            ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Completed));
                    }
                    else
                    {
                        if (nextGames[0].Status == Game.GamePlatform.GameStatus.NotYetReleased)
                            ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.NotYetReleased));
                        else if (nextGames[0].Status == Game.GamePlatform.GameStatus.NotPlayed)
                            ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.NotPlayed));
                        else if (nextGames[0].Status == Game.GamePlatform.GameStatus.Finished)
                            ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Finished));
                        else if (nextGames[0].Status == Game.GamePlatform.GameStatus.Watched)
                            ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Watched));
                    }
                }
            }
        }

        private static List<Game> GetBundleGames(Bundle bundle)
        {
            List<Game> result = new List<Game>();
            if (bundle == null)
                return result;

            if (bundle.Name == BUNDLE_SUM)
                result = GetSumBundleGames();
            else if (bundle.Name == BUNDLE_NONE)
                result = GamesCollection.GetInstance().Games.FindAll(g => g.Bundles.Count == 0);
            else if (bundle.Name == BUNDLE_ALL)
                result = GamesCollection.GetInstance().Games;
            else
                foreach (Bundle.BundleGame bundleGame in GamesCollection.GetInstance().GetBundleGames(bundle))
                    result.Add(bundleGame.Game);

            return result;
        }

        private static bool IsBundleReal(Bundle bundle)
        {
            return bundle.Name != BUNDLE_NONE && bundle.Name != BUNDLE_ALL && bundle.Name != BUNDLE_SUM;
        }

        #endregion

        #region Platforms

        private void RefreshPlatforms()
        {
            //dgvGroups.DataSource = new List<Platform>(_gamesCollection.Platforms);
            _gamesCollection.Platforms.ForEach(p => AddGroupRow(p));
            ColorPlatformsTable();
        }

        private void AddPlatform()
        {
            FormPlatform form = new FormPlatform();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _gamesCollection.Add(form.EditedPlatform);
            Save();
            RefreshGroupTable();
            SelectPlatform(form.EditedPlatform);
        }

        private void EditPlatform()
        {
            Platform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;

            if (new FormPlatform(selectedPlatform).ShowDialog() != DialogResult.OK)
                return;

            Save();
            RefreshGroupTable();
            SelectPlatform(selectedPlatform);
        }

        private void DeletePlatform()
        {
            Platform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;

            _gamesCollection.Platforms.Remove(selectedPlatform);
            Save();
            RefreshGroupTable();
        }

        private Platform GetSelectedPlatform()
        {
            if (dgvGroups.SelectedRows.Count == 0 || dgvGroups.SelectedRows[0].Index == -1)
                return null;

            return dgvGroups.SelectedRows[0].Tag as Platform;
        }

        private void SelectPlatform(Platform platform)
        {
            if (tscbGroup.SelectedIndex != 1)
                return;

            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Platform rowPlatform;

                if (row.Tag is Platform)
                    rowPlatform = row.Tag as Platform;
                else
                    continue;

                if (rowPlatform == platform)
                {
                    row.Selected = true;
                    dgvGroups.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void ColorPlatformsTable()
        {
            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Platform platform = row.Tag as Platform;
                if (platform == null)
                    continue;

                List<Game> platformGames = _gamesCollection.Games.FindAll(g => g.Platforms.Exists(p => p.Platform == platform));
                if (platformGames.Count == 0)
                    continue;
                else if (!platformGames.Exists(pg => pg.Status != Game.GamePlatform.GameStatus.Skipped))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Skipped));
                else if (platformGames.Exists(pg => pg.Status == Game.GamePlatform.GameStatus.Playing &&
                                                    pg.Platforms.Exists(p => p.Platform == platform && p.Status == Game.GamePlatform.GameStatus.Playing)))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Playing));
                else if (platformGames.Exists(pg => pg.Status == Game.GamePlatform.GameStatus.OnHold &&
                                                    pg.Platforms.Exists(p => p.Platform == platform && p.Status == Game.GamePlatform.GameStatus.OnHold)))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.OnHold));
                else if (!platformGames.Exists(pg => pg.Status != Game.GamePlatform.GameStatus.WaitTranslation))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.WaitTranslation));
                else if (platformGames.Exists(pg => pg.Status == Game.GamePlatform.GameStatus.NotPlayed &&
                                                    pg.Platforms.Exists(p => p.Platform == platform && p.Status == Game.GamePlatform.GameStatus.NotPlayed)))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.NotPlayed));
            }
        }

        #endregion

        #region Genres

        private void RefreshGenres()
        {
            //dgvGroups.DataSource = new List<Genre>(_gamesCollection.Genres);
            _gamesCollection.Genres.ForEach(g => AddGroupRow(g));
            ColorGenresTable();
        }

        private void AddGenre()
        {
            FormGenre form = new FormGenre();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _gamesCollection.Add(form.EditedGenre);
            Save();
            RefreshGroupTable();
            SelectGenre(form.EditedGenre);
        }

        private void EditGenre()
        {
            Genre selectedGenre = GetSelectedGenre();
            if (selectedGenre == null)
                return;

            if (new FormGenre(selectedGenre).ShowDialog() != DialogResult.OK)
                return;

            Save();
            RefreshGroupTable();
            SelectGenre(selectedGenre);
        }

        private void DeleteGenre()
        {
            Genre selectedGenre = GetSelectedGenre();
            if (selectedGenre == null)
                return;

            _gamesCollection.Genres.Remove(selectedGenre);
            Save();
            RefreshGroupTable();
        }

        private Genre GetSelectedGenre()
        {
            if (dgvGroups.SelectedRows.Count == 0 || dgvGroups.SelectedRows[0].Index == -1)
                return null;

            return dgvGroups.SelectedRows[0].Tag as Genre;
        }

        private void SelectGenre(Genre genre)
        {
            if (tscbGroup.SelectedIndex != 2)
                return;

            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Genre rowGenre;

                if (row.Tag is Genre)
                    rowGenre = row.Tag as Genre;
                else
                    continue;

                if (rowGenre == genre)
                {
                    row.Selected = true;
                    dgvGroups.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void ColorGenresTable()
        {
            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Genre genre = row.Tag as Genre;
                if (genre == null)
                    continue;

                List<Game> genreGames = _gamesCollection.Games.FindAll(g => g.Genres.Contains(genre));
                if (genreGames.Count == 0)
                    continue;
                else if (!genreGames.Exists(bg => bg.Status != Game.GamePlatform.GameStatus.Skipped))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Skipped));
                else if (genreGames.Exists(bg => bg.Status == Game.GamePlatform.GameStatus.Playing))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.Playing));
                else if (genreGames.Exists(bg => bg.Status == Game.GamePlatform.GameStatus.OnHold))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.OnHold));
                else if (!genreGames.Exists(bg => bg.Status != Game.GamePlatform.GameStatus.WaitTranslation))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.WaitTranslation));
                else if (genreGames.Exists(bg => bg.Status == Game.GamePlatform.GameStatus.NotPlayed))
                    ColorRow(row, Game.ColorByStatus(Game.GamePlatform.GameStatus.NotPlayed));
            }
        }

        #endregion

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            RefreshGamesTable();
        }

        #endregion

        #region Games

        private void RefreshChart()
        {
            Dictionary<Game.GamePlatform.GameStatus, int> colorsCounts = new Dictionary<Game.GamePlatform.GameStatus, int>();

            foreach (DataGridViewRow row in dgvGames.Rows)
            {
                Game game = GetGameFromRow(row);
                if (!colorsCounts.ContainsKey(game.Status))
                    colorsCounts.Add(game.Status, 0);
                colorsCounts[game.Status]++;
            }

            Series series = chart.Series[0];
            series.Points.Clear();
            foreach (Game.GamePlatform.GameStatus key in colorsCounts.Keys)
            {
                int pointNum = series.Points.AddY(colorsCounts[key]);
                DataPoint point = series.Points[pointNum];
                point.Color = Game.ColorByStatus(key);
                point.IsValueShownAsLabel = true;
                point.ToolTip = key.ToString();
                //point.Label = colorsCounts[key].ToString();
            }
        }

        private void RefreshGamesTable()
        {
            colGameNumber.Visible = false;
            tsbGameUp.Visible = false;
            tsbGameDown.Visible = false;
            tsbGameExclusives.Visible = false;
            tsbChosen.Visible = false;
            tssGameMove.Visible = false;

            switch (tscbGroup.SelectedIndex)
            {
                case 0:
                    Bundle selectedBundle = GetSelectedBundle();
                    if (selectedBundle != null)
                        ShowGamesByBundle(selectedBundle);
                    break;
                case 1:
                    Platform selectedPlatform = GetSelectedPlatform();
                    if (selectedPlatform != null)
                        ShowGamesByPlatform(selectedPlatform);
                    break;
                case 2:
                    Genre selectedGenre = GetSelectedGenre();
                    if (selectedGenre != null)
                        ShowGamesByGenre(selectedGenre);
                    break;
                default:
                    dgvGames.DataSource = new List<Game>(_gamesCollection.Games);
                    break;
            }

            int readyGames = 0;
            foreach (DataGridViewRow row in dgvGames.Rows)
            {
                Game game = GetGameFromRow(row);
                if (game == null)
                    continue;

                if (game.Ready)
                    readyGames++;
            }

            tsslGamesCount.Text = "" + dgvGames.Rows.Count;
            tsslReadyGamesCount.Text = "" + readyGames;
            dgvGames.ClearSelection();
            ColorGamesTable();

            foreach (DataGridViewRow row in dgvGames.Rows)
                row.Height = 30;

            RefreshChart();
        }

        private void ColorGamesTable()
        {
            foreach (DataGridViewRow row in dgvGames.Rows)
            {
                Game game = GetGameFromRow(row);
                if (game == null)
                    continue;

                ColorRow(row, game.Color);
            }
        }

        private List<Game> GetFilteredList(List<Game> games)
        {
            List<Game> result = new List<Game>();

            foreach (Game game in games)
            {
                if (tsbGameStarted.Checked && !(game.Started && game.Ready))
                    continue;

                if (tstbFilter.Text.Trim() != "" && !game.ToString().ToLower().Contains(tstbFilter.Text.ToLower()))
                    continue;

                if (tsbBuyList.Checked)
                {
                    if (!_gamesCollection.IsGameNext(game))
                        continue;
                    if (game.Have)
                        continue;
                }

                result.Add(game);
            }

            return result;
        }

        private void ShowGamesByBundle(Bundle bundle)
        {
            if (bundle.Name == BUNDLE_NONE)
                dgvGames.DataSource = GetFilteredList(_gamesCollection.Games.FindAll(g => g.Bundles.Count == 0));
            else if (bundle.Name == BUNDLE_ALL)
                dgvGames.DataSource = GetFilteredList(_gamesCollection.Games);
            else if (bundle.Name == BUNDLE_SUM)
                dgvGames.DataSource = GetFilteredList(GetSumBundleGames());
            else
            {
                dgvGames.DataSource = _gamesCollection.GetBundleGames(bundle).FindAll(g => (!tsbGameStarted.Checked || (g.Game.Started && g.Ready)));
                colGameNumber.Visible = true;
                tsbGameUp.Visible = true;
                tsbGameDown.Visible = true;
                tssGameMove.Visible = true;
            }
        }

        private static List<Game> GetSumBundleGames()
        {
            List<Game> result = new List<Game>();
            foreach (Game game in GamesCollection.GetInstance().Games)
            {
                if (game.Date > DateTime.Today)
                    continue;
                if (game.Status == Game.GamePlatform.GameStatus.Completed ||
                    game.Status == Game.GamePlatform.GameStatus.Dropped ||
                    game.Status == Game.GamePlatform.GameStatus.Skipped)
                    continue;
                if (game.Status == Game.GamePlatform.GameStatus.Playing ||
                    game.Status == Game.GamePlatform.GameStatus.OnHold)
                {
                    result.Add(game);
                    continue;
                }

                if (GamesCollection.GetInstance().IsGameNext(game))
                    result.Add(game);
            }
            return result;
        }

        private void ShowGamesByGenre(Genre genre)
        {
            dgvGames.DataSource = GetFilteredList(_gamesCollection.Games.FindAll(g => g.Genres.Contains(genre)));
        }

        private void ShowGamesByPlatform(Platform platform)
        {
            dgvGames.DataSource = GetFilteredList(_gamesCollection.Games.FindAll(g => g.Platforms.Exists(p => p.Platform == platform) &&
                                                                                     (!tsbGameExclusives.Checked || g.Platforms.Count == 1) &&
                                                                                     (!tsbChosen.Checked || g.Platforms[0].Platform == platform) &&
                                                                                     (!tsbGameStarted.Checked || (g.Started &&
                                                                                         g.Platforms.Exists(p => p.Platform == platform &&
                                                                                                                 p.Status == g.Status &&
                                                                                                                 p.Have && platform.Have)))));
            tsbGameExclusives.Visible = true;
            tsbChosen.Visible = true;
        }

        private void tsbGameAdd_Click(object sender, EventArgs e)
        {
            Game newGame = new Game();

            Bundle selectedBundle = GetSelectedBundle();
            if (selectedBundle != null && IsBundleReal(selectedBundle))
                newGame.Bundles.Add(_gamesCollection.GetGameBundle(selectedBundle));

            ucGame.SetGame(newGame);
            ucGame.BringToFront();

            /*FormGame form = new FormGame(newGame);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _gamesCollection.Add(form.EditedGame);
            Save();
            RefreshGamesTable();

            SelectGame(form.EditedGame);*/
        }

        private void tsbGameEdit_Click(object sender, EventArgs e) => EditGame();

        private void tsbGameDelete_Click(object sender, EventArgs e)
        {
            Game selectedGame = GetSelectedGame();
            if (selectedGame == null)
                return;

            if (MessageBox.Show("Вы дейтсвительно хотите удалить " + selectedGame.ToString() + "?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _gamesCollection.Remove(selectedGame);
            Save();
            RefreshGamesTable();
        }

        private void tsbGameUp_Click(object sender, EventArgs e)
        {
            Bundle selectedBundle = GetSelectedBundle();
            Game selectedGame = GetSelectedGame();

            if (selectedBundle == null || selectedGame == null)
                return;

            Game.GameBundle selectedGameBundle = selectedGame.Bundles.Find(b => b.Bundle == selectedBundle);
            if (selectedGameBundle == null)
                return;
            int selectedGameNumber = selectedGameBundle.Number;

            List<Game> bundleGames = _gamesCollection.Games.FindAll(g => g.Bundles.Exists(b => b.Bundle == selectedBundle));
            Game.GameBundle previousGameBundle = null;
            foreach (Game game in bundleGames)
            {
                Game.GameBundle gameBundle = game.Bundles.Find(b => b.Bundle == selectedBundle);
                if (gameBundle == null || gameBundle.Number >= selectedGameNumber)
                    continue;

                if (previousGameBundle == null || previousGameBundle.Number < gameBundle.Number)
                    previousGameBundle = gameBundle;
            }

            if (previousGameBundle == null)
                return;

            selectedGameBundle.Number = previousGameBundle.Number;
            previousGameBundle.Number = selectedGameNumber;
            Save();
            RefreshGamesTable();
            SelectGame(selectedGame);
        }

        private void tsbGameDown_Click(object sender, EventArgs e)
        {
            Bundle selectedBundle = GetSelectedBundle();
            Game selectedGame = GetSelectedGame();

            if (selectedBundle == null || selectedGame == null)
                return;

            Game.GameBundle selectedGameBundle = selectedGame.Bundles.Find(b => b.Bundle == selectedBundle);
            if (selectedGameBundle == null)
                return;
            int selectedGameNumber = selectedGameBundle.Number;

            List<Game> bundleGames = _gamesCollection.Games.FindAll(g => g.Bundles.Exists(b => b.Bundle == selectedBundle));
            Game.GameBundle nextGameBundle = null;
            foreach (Game game in bundleGames)
            {
                Game.GameBundle gameBundle = game.Bundles.Find(b => b.Bundle == selectedBundle);
                if (gameBundle == null || gameBundle.Number <= selectedGameNumber)
                    continue;

                if (nextGameBundle == null || nextGameBundle.Number > gameBundle.Number)
                    nextGameBundle = gameBundle;
            }

            if (nextGameBundle == null)
                return;

            selectedGameBundle.Number = nextGameBundle.Number;
            nextGameBundle.Number = selectedGameNumber;
            Save();
            RefreshGamesTable();
            SelectGame(selectedGame);
        }

        private void tsbExclusives_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGamesTable();
        }

        private void tsbChosen_Click(object sender, EventArgs e)
        {
            RefreshGamesTable();
        }

        private void tsbGameStarted_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGamesTable();
        }

        private void tsbBuyList_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGamesTable();
        }

        private void tstbFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshGamesTable();
        }

        private Game GetSelectedGame()
        {
            if (dgvGames.SelectedRows.Count == 0 || dgvGames.SelectedRows[0].Index == -1)
                return null;

            return GetGameFromRow(dgvGames.SelectedRows[0]);
        }

        private Game GetGameFromRow(DataGridViewRow row)
        {
            if (row == null)
                return null;

            if (row.DataBoundItem is Game)
                return row.DataBoundItem as Game;
            else if (row.DataBoundItem is Bundle.BundleGame)
                return (row.DataBoundItem as Bundle.BundleGame).Game;
            else
                return null;
        }

        private void SelectGame(Game game)
        {
            foreach (DataGridViewRow row in dgvGames.Rows)
            {
                Game rowGame;

                if (row.DataBoundItem is Game)
                    rowGame = row.DataBoundItem as Game;
                else if (row.DataBoundItem is Bundle.BundleGame)
                    rowGame = (row.DataBoundItem as Bundle.BundleGame).Game;
                else
                    continue;

                if (rowGame == game)
                {
                    row.Selected = true;
                    dgvGames.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void EditGame()
        {
            Game selectedGame = GetSelectedGame();
            if (selectedGame == null)
                return;

            ucGame.SetGame(selectedGame);

            /*DateTime gameDate = selectedGame.Date;
            if (new FormGame(selectedGame).ShowDialog() != DialogResult.OK)
                return;

            if (gameDate != selectedGame.Date)
                _gamesCollection.Games.Sort(Game.CompareByDate);
            Save();
            RefreshGamesTable();
            SelectGame(selectedGame);*/
        }

        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            Game selectedGame = GetSelectedGame();
            if (selectedGame != null)
            {
                ucGame.BringToFront();
                ucGame.SetGame(selectedGame);
            }
            else
            {
                ucGame.ClearGame();
                pEmpty.BringToFront();
            }
        }

        #endregion

        public class MultiColorDataGridViewTextBoxCell : DataGridViewTextBoxCell
        {
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                if (this.DataGridView.Rows[this.RowIndex].Selected)
                    base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                else
                {
                    graphics.FillRectangle(
                        new SolidBrush(cellStyle.BackColor),
                        new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width, (int)Math.Floor(cellBounds.Height * 0.85))
                    );
                    DrawStats(
                        graphics,
                        new Rectangle(cellBounds.X, cellBounds.Y + (int)Math.Floor(cellBounds.Height * 0.85), cellBounds.Width, (int)Math.Floor(cellBounds.Height * 0.15)),
                        this.DataGridView.Rows[this.RowIndex].Tag);
                    //graphics.DrawString((String)formattedValue, cellStyle.Font, Brushes.Black, cellBounds.X, cellBounds.Y, GetStringFormat(cellStyle));
                    TextRenderer.DrawText(graphics, (String)formattedValue, cellStyle.Font, cellBounds, cellStyle.ForeColor, cellStyle.BackColor,
                        GetStringFormatFlags(cellStyle) | TextFormatFlags.GlyphOverhangPadding);
                    this.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
                }
            }

            private void DrawStats(Graphics graphics, Rectangle cellBounds, object rowTag)
            {
                List<Game> games;
                if (rowTag is Bundle)
                    games = GetBundleGames(rowTag as Bundle);
                else if (rowTag is Platform)
                    games = GamesCollection.GetInstance().Games.FindAll(g => g.Platforms.Exists(p => p.Platform == rowTag as Platform));
                else if (rowTag is Genre)
                    games = GamesCollection.GetInstance().Games.FindAll(g => g.Genres.Contains(rowTag as Genre));
                else
                    games = new List<Game>();

                if (games.Count == 0)
                    graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height));
                else
                {
                    int gameWidth = cellBounds.Width / games.Count;
                    int offsetX = 0;
                    if (gameWidth != 0)
                    {
                        int correction = cellBounds.Width - gameWidth * games.Count;
                        if (correction > 0)
                            gameWidth++;
                        else
                            correction = -1;
                        foreach (Game game in games)
                        {
                            graphics.FillRectangle(new SolidBrush(game.Color),
                                new Rectangle(cellBounds.X + offsetX, cellBounds.Y, gameWidth, cellBounds.Height));
                            offsetX += gameWidth;

                            if (correction > 0)
                                correction--;
                            else if (correction == 0)
                            {
                                gameWidth--;
                                correction = -1;
                            }
                        }
                    }
                    else
                    {
                        Dictionary<Color, int> gamesColors = GetColorsFromGames(games);
                        foreach (Color key in gamesColors.Keys)
                        {
                            int width = cellBounds.Width * gamesColors[key] / games.Count;
                            if (width == 0)
                                continue;
                            graphics.FillRectangle(new SolidBrush(key),
                                new Rectangle(cellBounds.X + offsetX, cellBounds.Y, width, cellBounds.Height));
                            offsetX += width;
                        }
                    }

                    if (offsetX < cellBounds.Width)
                        graphics.FillRectangle(new SolidBrush(Color.White),
                            new Rectangle(cellBounds.X + offsetX, cellBounds.Y, cellBounds.Width - cellBounds.X - offsetX, cellBounds.Height));
                }
            }
            
            private Dictionary<Color, int> GetColorsFromGames(List<Game> games)
            {
                Dictionary<Color, int> result = new Dictionary<Color, int>();

                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.NotPlayed), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Playing), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.OnHold), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Dropped), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Skipped), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.WaitTranslation), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Watched), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Finished), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Completed), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.NotYetReleased), 0);
                result.Add(Game.ColorByStatus(Game.GamePlatform.GameStatus.Unknown), 0);

                foreach (Game game in games)
                    result[game.Color]++;

                return result;
            }

            private StringFormat GetStringFormat(DataGridViewCellStyle cellStyle)
            {
                StringFormat result = new StringFormat();
                switch (cellStyle.Alignment)
                {
                    case DataGridViewContentAlignment.BottomCenter:
                    case DataGridViewContentAlignment.BottomLeft:
                    case DataGridViewContentAlignment.BottomRight:
                        result.LineAlignment = StringAlignment.Far;
                        break;
                    case DataGridViewContentAlignment.MiddleCenter:
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.MiddleRight:
                    case DataGridViewContentAlignment.NotSet:
                        result.LineAlignment = StringAlignment.Center;
                        break;
                    case DataGridViewContentAlignment.TopCenter:
                    case DataGridViewContentAlignment.TopLeft:
                    case DataGridViewContentAlignment.TopRight:
                        result.LineAlignment = StringAlignment.Near;
                        break;
                }
                switch (cellStyle.Alignment)
                {
                    case DataGridViewContentAlignment.BottomCenter:
                    case DataGridViewContentAlignment.MiddleCenter:
                    case DataGridViewContentAlignment.TopCenter:
                        result.Alignment = StringAlignment.Center;
                        break;
                    case DataGridViewContentAlignment.BottomLeft:
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.TopLeft:
                    case DataGridViewContentAlignment.NotSet:
                        result.Alignment = StringAlignment.Near;
                        break;
                    case DataGridViewContentAlignment.BottomRight:
                    case DataGridViewContentAlignment.MiddleRight:
                    case DataGridViewContentAlignment.TopRight:
                        result.Alignment = StringAlignment.Far;
                        break;
                }

                return result;
            }

            private TextFormatFlags GetStringFormatFlags(DataGridViewCellStyle cellStyle)
            {
                switch (cellStyle.Alignment)
                {
                    case DataGridViewContentAlignment.BottomCenter:
                        return TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                    case DataGridViewContentAlignment.BottomLeft:
                        return TextFormatFlags.Bottom | TextFormatFlags.Left;
                    case DataGridViewContentAlignment.BottomRight:
                        return TextFormatFlags.Bottom | TextFormatFlags.Right;
                    case DataGridViewContentAlignment.MiddleCenter:
                        return TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
                    case DataGridViewContentAlignment.MiddleRight:
                        return TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                    case DataGridViewContentAlignment.TopCenter:
                        return TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                    case DataGridViewContentAlignment.TopLeft:
                        return TextFormatFlags.Top | TextFormatFlags.Left;
                    case DataGridViewContentAlignment.TopRight:
                        return TextFormatFlags.Top | TextFormatFlags.Right;
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.NotSet:
                    default:
                        return TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                }
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {
            Point pos = System.Windows.Forms.Cursor.Position;
            Point clientpos = chart.PointToClient(pos);
            HitTestResult contr = chart.HitTest(clientpos.X, clientpos.Y);
            if (contr.Series != null && contr.PointIndex != -1)
                MessageBox.Show(contr.ChartElementType.ToString() + Environment.NewLine + contr.Series.Points[contr.PointIndex]);
        }

        //private void dgvGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => EditGame();

        private void UcGame_GameSaved(object sender, Game game)
        {
            if (!_gamesCollection.Games.Contains(game))
                _gamesCollection.Add(game);
            else 
                _gamesCollection.Games.Sort(Game.CompareByDate);

            Save();
            RefreshGamesTable();
            SelectGame(game);
        }

        private void UcGame_BundleSelected(object sender, Bundle e)
        {
            Game selectedGame = ucGame.EditedGame;
            tscbGroup.SelectedIndex = 0;
            SelectBundle(e);
            SelectGame(selectedGame);
        }

        private void UcGame_PlatformSelected(object sender, Platform e)
        {
            Game selectedGame = ucGame.EditedGame;
            tscbGroup.SelectedIndex = 1;
            SelectPlatform(e);
            SelectGame(selectedGame);
        }

        private void UcGame_GenreSelected(object sender, Genre e)
        {
            Game selectedGame = ucGame.EditedGame;
            tscbGroup.SelectedIndex = 2;
            SelectGenre(e);
            SelectGame(selectedGame);
        }
    }
}

// вынести информацию об игре и платформе/бандле/жанре в отдельные юзерконтролы
// сделать открытие юзерконтрола в отдельном окне по даблклику