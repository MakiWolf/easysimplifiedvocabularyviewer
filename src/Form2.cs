namespace viewer;

public partial class Form2 : Form
{
    
    public Form2()
    {
        InitializeComponent();
        label2.Text = Program.version;
        label3.Text = "View vocabulary from local sqlite db file from \r\n easysimplifiedvocabularytrainer.";
    }


}
