using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesList.Classes;
using System.Runtime.CompilerServices;

namespace GamesList.Forms
{
    public partial class UserControlGame : UserControl
    {
        public Game EditedGame;
        private bool changed = false;

        private List<Game.GameBundle> bundles;
        private List<Genre> genres;
        private List<Game.GamePlatform> platforms;

        public UserControlGame()
        {
            InitializeComponent();

            dgvBundles.AutoGenerateColumns = false;
            dgvGenres.AutoGenerateColumns = false;
            dgvPlatforms.AutoGenerateColumns = false;

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Играбельно");
            cbStatus.Items.Add("Отвергнута");
            cbStatus.Items.Add("Пропущена");
            cbStatus.Items.Add("Ожидает перевода");
            cbStatus.Items.Add("Неизвестно");
            cbStatus.SelectedIndex = 0;

            ClearGame();
        }

        public void SetGame(Game game)
        {
            if (changed)
            {
                DialogResult dialogResult = MessageBox.Show("Имеются несохраненные данные. Сохранить?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    Save();
                else if (dialogResult == DialogResult.Cancel)
                    return;
            }

            bundles = new List<Game.GameBundle>(game.Bundles);
            genres = new List<Genre>(game.Genres);
            platforms = new List<Game.GamePlatform>(game.Platforms);

            EditedGame = game;

            tbName.Text = game.Name;
            tbComment.Text = game.Comment;
            dtpDate.Value = game.Date;

            switch (game.DefaultStatus)
            {
                case Game.GamePlatform.GameStatus.NotPlayed: cbStatus.SelectedIndex = 0; break;
                case Game.GamePlatform.GameStatus.Dropped: cbStatus.SelectedIndex = 1; break;
                case Game.GamePlatform.GameStatus.Skipped: cbStatus.SelectedIndex = 2; break;
                case Game.GamePlatform.GameStatus.WaitTranslation: cbStatus.SelectedIndex = 3; break;
                default: cbStatus.SelectedIndex = 4; break;
            }

            dgvBundles.DataSource = new List<Game.GameBundle>(bundles);
            dgvGenres.DataSource = new List<Genre>(genres);
            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            changed = false;
        }

        public void ClearGame()
        {
            changed = false;
            SetGame(new Game());
        }

        private void fieldValue_Changed(object sender, EventArgs e)
        {
            changed = true;
        }

        #region Menu Buttons

        private void tsmiBundleAdd_Click(object sender, EventArgs e)
        {
            FormChoice form = new FormChoice(FormChoice.Selection.Bundle);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            GamesCollection gamesCollection = GamesCollection.GetInstance();
            bundles.Add(gamesCollection.GetGameBundle(form.SelectedBundle));
            dgvBundles.DataSource = new List<Game.GameBundle>(bundles);

            fieldValue_Changed(sender, e);
        }

        private void tsmiBundleDelete_Click(object sender, EventArgs e)
        {
            Game.GameBundle selectedBundle = GetSelectedBundle();
            if (selectedBundle == null)
                return;

            bundles.Remove(selectedBundle);
            dgvBundles.DataSource = new List<Game.GameBundle>(bundles);

            fieldValue_Changed(sender, e);
        }

        private void tsmiPlatformAdd_Click(object sender, EventArgs e)
        {
            FormGamePlatform form = new FormGamePlatform();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            platforms.Add(form.EditedPlatform);
            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            SelectPlatform(form.EditedPlatform);

            fieldValue_Changed(sender, e);
        }

        private void tsmiPlatformEdit_Click(object sender, EventArgs e)
        {
            Game.GamePlatform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;

            FormGamePlatform form = new FormGamePlatform(selectedPlatform);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            SelectPlatform(selectedPlatform);

            fieldValue_Changed(sender, e);
        }

        private void tsmiPlatformDelete_Click(object sender, EventArgs e)
        {
            Game.GamePlatform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;

            platforms.Remove(selectedPlatform);
            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            fieldValue_Changed(sender, e);
        }

        private void tsmiPlatformUp_Click(object sender, EventArgs e)
        {
            Game.GamePlatform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;
            int currentIndex = platforms.IndexOf(selectedPlatform);
            if (currentIndex == 0)
                return;

            platforms.Remove(selectedPlatform);
            platforms.Insert(currentIndex - 1, selectedPlatform);

            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            SelectPlatform(selectedPlatform);

            fieldValue_Changed(sender, e);
        }

        private void tsmiPlatformDown_Click(object sender, EventArgs e)
        {
            Game.GamePlatform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;
            int currentIndex = platforms.IndexOf(selectedPlatform);
            if (currentIndex == platforms.Count - 1)
                return;

            platforms.Remove(selectedPlatform);
            platforms.Insert(currentIndex + 1, selectedPlatform);

            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            SelectPlatform(selectedPlatform);

            fieldValue_Changed(sender, e);
        }

        private void tsmiApplyDefaultStatus_Click(object sender, EventArgs e)
        {
            Game.GamePlatform.GameStatus selecteDefaultStatus = GetSelectedDefaultStatus();
            foreach (Game.GamePlatform platform in platforms)
                platform.Status = selecteDefaultStatus;

            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            fieldValue_Changed(sender, e);
        }

        private void tsmiGenreAdd_Click(object sender, EventArgs e)
        {
            FormChoice form = new FormChoice(FormChoice.Selection.Genre);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            genres.Add(form.SelectedGenre);
            dgvGenres.DataSource = new List<Genre>(genres);

            fieldValue_Changed(sender, e);
        }

        private void tsmiGenreDelete_Click(object sender, EventArgs e)
        {
            Genre selectedGenre = GetSelectedGenre();
            if (selectedGenre == null)
                return;

            genres.Remove(selectedGenre);
            dgvGenres.DataSource = new List<Genre>(genres);

            fieldValue_Changed(sender, e);
        }

        #endregion

        #region Tables

        private void dgvBundles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Game.GameBundle selectedBundle = GetSelectedBundle();
            if (selectedBundle == null)
                return;

            OnBundleSelected(selectedBundle.Bundle);
        }

        private void dgvPlatforms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Game.GamePlatform selectedPlatdorm = GetSelectedPlatform();
            if (selectedPlatdorm == null)
                return;

            OnPlatformSelected(selectedPlatdorm.Platform);
        }

        private void dgvGenres_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Genre selectedGenre = GetSelectedGenre();
            if (selectedGenre == null)
                return;

            OnGenreSelected(selectedGenre);
        }

        private Game.GameBundle GetSelectedBundle()
        {
            if (dgvBundles.SelectedRows.Count == 0 || dgvBundles.SelectedRows[0].Index == -1)
                return null;

            return dgvBundles.SelectedRows[0].DataBoundItem as Game.GameBundle;
        }

        private Game.GamePlatform GetSelectedPlatform()
        {
            if (dgvPlatforms.SelectedRows.Count == 0 || dgvPlatforms.SelectedRows[0].Index == -1)
                return null;

            return dgvPlatforms.SelectedRows[0].DataBoundItem as Game.GamePlatform;
        }

        private Genre GetSelectedGenre()
        {
            if (dgvGenres.SelectedRows.Count == 0 || dgvGenres.SelectedRows[0].Index == -1)
                return null;

            return dgvGenres.SelectedRows[0].DataBoundItem as Genre;
        }

        #endregion

        #region Platform

        private Game.GamePlatform.GameStatus GetSelectedDefaultStatus()
        {
            switch (cbStatus.SelectedIndex)
            {
                case 0: return Game.GamePlatform.GameStatus.NotPlayed;
                case 1: return Game.GamePlatform.GameStatus.Dropped;
                case 2: return Game.GamePlatform.GameStatus.Skipped;
                case 3: return Game.GamePlatform.GameStatus.WaitTranslation;
                default: return Game.GamePlatform.GameStatus.Unknown;
            }
        }

        private void SelectPlatform(Game.GamePlatform platform)
        {
            foreach (DataGridViewRow row in dgvPlatforms.Rows)
                if (row.DataBoundItem == platform)
                {
                    row.Selected = true;
                    dgvPlatforms.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
        }

        #endregion

        private void btOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            EditedGame.Name = tbName.Text;
            EditedGame.Comment = tbComment.Text;
            EditedGame.Date = dtpDate.Value.Date;
            EditedGame.DefaultStatus = GetSelectedDefaultStatus();

            EditedGame.Bundles = bundles;
            EditedGame.Platforms = platforms;
            EditedGame.Genres = genres;

            changed = false;

            OnGameSaved(EditedGame);
        }

        #region Events

        public event EventHandler<Game> GameSaved;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnGameSaved(Game game)
        {
            if (GameSaved != null)
                GameSaved(this, game);
        }

        public event EventHandler<Bundle> BundleSelected;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnBundleSelected(Bundle bundle)
        {
            if (BundleSelected != null)
                BundleSelected(this, bundle);
        }

        public event EventHandler<Platform> PlatformSelected;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnPlatformSelected(Platform platform)
        {
            if (PlatformSelected != null)
                PlatformSelected(this, platform);
        }

        public event EventHandler<Genre> GenreSelected;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnGenreSelected(Genre genre)
        {
            if (GenreSelected != null)
                GenreSelected(this, genre);
        }

        #endregion
    }
}