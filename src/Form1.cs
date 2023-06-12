using System.Data.SQLite;
using Dapper.Contrib.Extensions;

namespace viewer;

public partial class Form1 : Form
{

    DatabaseManager databasemanager = new DatabaseManager();
    private BindingSource binding1;
    public Form1()
    {
        InitializeComponent();

        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.ReadOnly = true;
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        textBoxsource.Text = "vocabulary.db";
        textbox(false);
        try
        {
            if (File.Exists(Program.database))
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("db file does not exist!");
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }


    private void LoadData()
    {
        binding1 = new BindingSource();
        binding1.DataSource = databasemanager.GetData();
        dataGridView1.DataSource = binding1;
    }

    private void BINDING()
    {
        textBoxlanguage1.DataBindings.Clear();
        textBoxlanguage1.DataBindings.Add("Text", dataGridView1.DataSource, "language1");
        textBoxlanguage2.DataBindings.Clear();
        textBoxlanguage2.DataBindings.Add("Text", dataGridView1.DataSource, "language2");
        textBoxmistakes.DataBindings.Clear();
        textBoxmistakes.DataBindings.Add("Text", dataGridView1.DataSource, "mistakes");
    }

    private void UNBIND()
    {
        textBoxlanguage1.DataBindings.Clear();
        textBoxlanguage2.DataBindings.Clear();
        textBoxmistakes.DataBindings.Clear();
    }
    private void textbox(bool enabled)
    {
        textBoxlanguage1.Enabled = enabled;
        textBoxlanguage2.Enabled = enabled;
        textBoxmistakes.Enabled = enabled;
    }

    private void dataGridView1_Click(object sender, EventArgs e)
    {
        BINDING();
        textbox(true);
    }

    private void button1_Click(object sender, EventArgs e)
    {

        if (!(dataGridView1.DataSource is BindingSource))
            return;

        var a = binding1.Current;
        using (var connection = new SQLiteConnection(Program.t))
        {

            connection.UpdateAsync<NAME>(binding1.Current as NAME);
            connection.Close();
        }
        UNBIND();
        LoadData();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            UNBIND();

            using (var connection = new SQLiteConnection(Program.t))
            {
                connection.Insert<NAME>(new NAME { language1 = textBoxlanguage1_1.Text, language2 = textBoxlanguage2_1.Text, mistakes = Convert.ToInt32(textBoxmistakes1.Text) });
                connection.Close();
            }
            binding1.DataSource = databasemanager.GetData();
            dataGridView1.DataSource = binding1;
            dataGridView1.Refresh();
        }
        catch
        {
            MessageBox.Show("Please enter something!", "?", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("delete?", "delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No)
        {
            return;
        }
        UNBIND();
        using (var connection = new SQLiteConnection(Program.t))
        {
            connection.Delete<NAME>(new NAME { ID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value), language1 = dataGridView1.SelectedCells[1].Value.ToString(), language2 = dataGridView1.SelectedCells[2].Value.ToString(), mistakes = Convert.ToInt32(dataGridView1.SelectedCells[3].Value) });
            connection.Close();
        }
        binding1.DataSource = databasemanager.GetData();
        dataGridView1.DataSource = binding1;
        dataGridView1.Refresh();
    }

    private void buttonfilter_Click(object sender, EventArgs e)
    {
        if (textBoxfilterlanguage1.Text == string.Empty && textBoxfilterlanguage2.Text == string.Empty)
        {
            binding1 = new BindingSource();
            binding1.DataSource = databasemanager.GetData();
            dataGridView1.DataSource = binding1;
        }
        else
        {
            binding1 = new BindingSource();
            binding1.DataSource = databasemanager.Getname(textBoxfilterlanguage1.Text, textBoxfilterlanguage2.Text);
            dataGridView1.DataSource = binding1;
        }
    }

    private void buttonfilterdelete_Click(object sender, EventArgs e)
    {
        textBoxfilterlanguage2.Text = "";
        textBoxfilterlanguage1.Text = "";
        binding1 = new BindingSource();
        binding1.DataSource = databasemanager.GetData();
        dataGridView1.DataSource = binding1;

    }

    private void buttonsource_Click(object sender, EventArgs e)
    {
        try
        {

            string source = textBoxsource.Text;
            Program.database = source;
            if (File.Exists(source))
            {
                Program.t = "Data Source=" + source + ";Version=3;";
                LoadData();
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonabout_Click(object sender, EventArgs e)
    {
        try
        {

            Form2 Form2 = new Form2();
            Form2.ShowDialog(); // Shows Form2
            //this.Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


}
