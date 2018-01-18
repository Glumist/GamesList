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

namespace GamesList.Forms
{
    public partial class FormGame : Form
    {
        public Game EditedGame;

        private List<Game.GameBundle> bundles;
        private List<Genre> genres;
        private List<Game.GamePlatform> platforms;

        public FormGame()
        {
            bundles = new List<Game.GameBundle>();
            genres = new List<Genre>();
            platforms = new List<Game.GamePlatform>();

            Init();

            EditedGame = new Game();
        }

        public FormGame(Game game)
        {
            bundles = new List<Game.GameBundle>(game.Bundles);
            genres = new List<Genre>(game.Genres);
            platforms = new List<Game.GamePlatform>(game.Platforms);

            Init();

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
        }

        private void Init()
        {
            InitializeComponent();

            dgvBundles.AutoGenerateColumns = false;
            dgvGenres.AutoGenerateColumns = false;
            dgvPlatforms.AutoGenerateColumns = false;

            dgvBundles.DataSource = new List<Game.GameBundle>(bundles);
            dgvGenres.DataSource = new List<Genre>(genres);
            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Играбельно");
            cbStatus.Items.Add("Отвергнута");
            cbStatus.Items.Add("Пропущена");
            cbStatus.Items.Add("Ожидает перевода");
            cbStatus.Items.Add("Неизвестно");
            cbStatus.SelectedIndex = 0;
        }

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

        private void tsmiBundleAdd_Click(object sender, EventArgs e)
        {
            FormChoice form = new FormChoice(FormChoice.Selection.Bundle);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            GamesCollection gamesCollection = GamesCollection.GetInstance();
            bundles.Add(gamesCollection.GetGameBundle(form.SelectedBundle));
            dgvBundles.DataSource = new List<Game.GameBundle>(bundles);
        }

        private void tsmiBundleDelete_Click(object sender, EventArgs e)
        {
            if (dgvBundles.SelectedRows.Count == 0 || dgvBundles.SelectedRows[0].Index == -1)
                return;

            Game.GameBundle selectedBundle = dgvBundles.SelectedRows[0].DataBoundItem as Game.GameBundle;
            if (selectedBundle == null)
                return;

            bundles.Remove(selectedBundle);
            dgvBundles.DataSource = new List<Game.GameBundle>(bundles);
        }

        private void tsmiPlatformAdd_Click(object sender, EventArgs e)
        {
            FormGamePlatform form = new FormGamePlatform();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            platforms.Add(form.EditedPlatform);
            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);

            SelectPlatform(form.EditedPlatform);
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
        }

        private void tsmiPlatformDelete_Click(object sender, EventArgs e)
        {
            Game.GamePlatform selectedPlatform = GetSelectedPlatform();
            if (selectedPlatform == null)
                return;

            platforms.Remove(selectedPlatform);
            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);
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
        }

        private void tsmiApplyDefaultStatus_Click(object sender, EventArgs e)
        {
            Game.GamePlatform.GameStatus selecteDefaultStatus = GetSelectedDefaultStatus();
            foreach (Game.GamePlatform platform in platforms)
                platform.Status = selecteDefaultStatus;

            dgvPlatforms.DataSource = new List<Game.GamePlatform>(platforms);
        }

        private Game.GamePlatform GetSelectedPlatform()
        {
            if (dgvPlatforms.SelectedRows.Count == 0 || dgvPlatforms.SelectedRows[0].Index == -1)
                return null;

            return dgvPlatforms.SelectedRows[0].DataBoundItem as Game.GamePlatform;
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

        private void tsmiGenreAdd_Click(object sender, EventArgs e)
        {
            FormChoice form = new FormChoice(FormChoice.Selection.Genre);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            genres.Add(form.SelectedGenre);
            dgvGenres.DataSource = new List<Genre>(genres);
        }

        private void tsmiGenreDelete_Click(object sender, EventArgs e)
        {
            if (dgvGenres.SelectedRows.Count == 0 || dgvGenres.SelectedRows[0].Index == -1)
                return;

            Genre selectedGenre = dgvGenres.SelectedRows[0].DataBoundItem as Genre;
            if (selectedGenre == null)
                return;

            genres.Remove(selectedGenre);
            dgvGenres.DataSource = new List<Genre>(genres);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedGame.Name = tbName.Text;
            EditedGame.Comment = tbComment.Text;
            EditedGame.Date = dtpDate.Value.Date;
            EditedGame.DefaultStatus = GetSelectedDefaultStatus();

            EditedGame.Bundles = bundles;
            EditedGame.Platforms = platforms;
            EditedGame.Genres = genres;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
