using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EfContext db = new EfContext();
        private void Form1_Load(object sender, EventArgs e)
        {

            dgv_players.DataSource = db.Players.Select(p => new { p.Id, p.Name, p.Position, Team = p.Team.Name }).ToList();
            ComboBox_team.DataSource = db.Teams.ToList();
            ComboBox_team.DisplayMember = "Name";
            ComboBox_team.ValueMember = "Id";

            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void ComboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_team_Click(object sender, EventArgs e)
        {
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_position_Click(object sender, EventArgs e)
        {
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Player s = new Player()
            {
                Id = int.Parse(txt_id.Text),
                Name = txt_name.Text,
                Position = txt_position.Text,
                TeamId = (int)ComboBox_team.SelectedValue
            };
            db.Players.Add(s);
            db.SaveChanges();

            txt_id.Text = txt_name.Text = txt_position.Text = "";
            dgv_players.DataSource = db.Players.Select(p => new { p.Id, p.Name, p.Position, Team = p.Team.Name }).ToList();

        }

        int id;
        private void dgv_players_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_players.SelectedRows[0].Cells[0].Value;
            Player s = db.Players.Where(s => s.Id == id).SingleOrDefault();
            txt_id.Text = s.Id.ToString();
            txt_name.Text = s.Name;
            txt_position.Text = s.Position.ToString();
            ComboBox_team.SelectedValue = s.TeamId;

            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Player s = db.Players.Where(s => s.Id == id).SingleOrDefault();
            s.Name = txt_name.Text;
            s.Position = txt_position.Text;
            s.TeamId = (int)ComboBox_team.SelectedValue;

            db.SaveChanges();

            txt_id.Text = txt_name.Text = txt_position.Text = "";


            dgv_players.DataSource = db.Players.Select(p => new { p.Id, p.Name, p.Position, Team = p.Team.Name }).ToList();
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Player s = db.Players.Where(s => s.Id == id).SingleOrDefault();
            db.Players.Remove(s);
            db.SaveChanges();
            txt_id.Text = txt_name.Text = txt_position.Text = "";

            dgv_players.DataSource = db.Players.Select(p => new { p.Id, p.Name, p.Position, Team = p.Team.Name }).ToList();
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;

        }
    }
}