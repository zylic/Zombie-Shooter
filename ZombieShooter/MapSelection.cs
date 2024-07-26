using System;

namespace ZombieShooter
{
    public partial class MapSelection : Form
    {
        public string SelectedMap { get; private set; }
        public event EventHandler<MapSelectedEventArgs> MapSelected;
        public MapSelection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MapSelection_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            Sounds.NavigateMainMenuEnterSound();
            Sounds.ChangeScreenSound();
            SelectedMap = ((PictureBox)sender).Name;
            MapSelected?.Invoke(this, new MapSelectedEventArgs(SelectedMap));
            Close();
            this.Dispose();
        }
    }
}
