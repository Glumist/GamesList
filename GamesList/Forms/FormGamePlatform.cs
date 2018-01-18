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
    public partial class FormGamePlatform : Form
    {
        public Game.GamePlatform EditedPlatform;
        private GamesCollection _gamesCollection;

        public FormGamePlatform()
        {
            Init();

            EditedPlatform = new Game.GamePlatform();
        }

        public FormGamePlatform(Game.GamePlatform platform)
        {
            Init();

            EditedPlatform = platform;
            cbPlatform.SelectedItem = platform.Platform;
            chbHave.Checked = platform.Have;

            switch (platform.Status)
            {
                case Game.GamePlatform.GameStatus.NotPlayed: cbStatus.SelectedIndex = 0; break;
                case Game.GamePlatform.GameStatus.Playing: cbStatus.SelectedIndex = 1; break;
                case Game.GamePlatform.GameStatus.OnHold: cbStatus.SelectedIndex = 2; break;
                case Game.GamePlatform.GameStatus.Dropped: cbStatus.SelectedIndex = 3; break;
                case Game.GamePlatform.GameStatus.Skipped: cbStatus.SelectedIndex = 4; break;
                case Game.GamePlatform.GameStatus.Finished: cbStatus.SelectedIndex = 5; break;
                case Game.GamePlatform.GameStatus.Completed: cbStatus.SelectedIndex = 6; break;
                case Game.GamePlatform.GameStatus.WaitTranslation: cbStatus.SelectedIndex = 7; break;
                case Game.GamePlatform.GameStatus.Watched: cbStatus.SelectedIndex = 8; break;
                default: cbStatus.SelectedIndex = 9; break;
            }
        }

        private void Init()
        {
            InitializeComponent();

            _gamesCollection = GamesCollection.GetInstance();
            RefreshPlatforms();

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Не начата");
            cbStatus.Items.Add("В процессе");
            cbStatus.Items.Add("В ожидании");
            cbStatus.Items.Add("Отвергнута");
            cbStatus.Items.Add("Пропущена");
            cbStatus.Items.Add("Закончена");
            cbStatus.Items.Add("Завершена");
            cbStatus.Items.Add("Ожидает перевода");
            cbStatus.Items.Add("Просмотрена");
            cbStatus.Items.Add("Неизвестно");
            cbStatus.SelectedIndex = 0;
        }

        private void RefreshPlatforms()
        {
            cbPlatform.Items.Clear();
            foreach (Platform platform in _gamesCollection.Platforms)
                cbPlatform.Items.Add(platform);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormPlatform form = new FormPlatform();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _gamesCollection.Add(form.EditedPlatform);
            _gamesCollection.Save();
            RefreshPlatforms();
            cbPlatform.SelectedItem = form.EditedPlatform;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedPlatform.Platform = (Platform)cbPlatform.SelectedItem;
            EditedPlatform.Have = chbHave.Checked;

            switch (cbStatus.SelectedIndex)
            {
                case 0: EditedPlatform.Status = Game.GamePlatform.GameStatus.NotPlayed; break;
                case 1: EditedPlatform.Status = Game.GamePlatform.GameStatus.Playing; break;
                case 2: EditedPlatform.Status = Game.GamePlatform.GameStatus.OnHold; break;
                case 3: EditedPlatform.Status = Game.GamePlatform.GameStatus.Dropped; break;
                case 4: EditedPlatform.Status = Game.GamePlatform.GameStatus.Skipped; break;
                case 5: EditedPlatform.Status = Game.GamePlatform.GameStatus.Finished; break;
                case 6: EditedPlatform.Status = Game.GamePlatform.GameStatus.Completed; break;
                case 7: EditedPlatform.Status = Game.GamePlatform.GameStatus.WaitTranslation; break;
                case 8: EditedPlatform.Status = Game.GamePlatform.GameStatus.Watched; break;
                default: EditedPlatform.Status = Game.GamePlatform.GameStatus.Unknown; break;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
