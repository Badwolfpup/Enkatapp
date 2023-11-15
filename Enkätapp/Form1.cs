using System.Security.Cryptography.X509Certificates;

namespace Enkätapp
{
    
    public partial class Form1 : Form
    {
        FlowLayoutPanel flow;
        List<Panel> panelList = new List<Panel>();
        int numberQ = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void createSurveryButton_Click(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control c = Controls[i];
                Controls.Remove(c);
            }
            flow = new FlowLayoutPanel();
            flow.Size = new Size(this.Width / 2, this.ClientSize.Height);
            flow.Location = new Point(this.ClientSize.Width / 2 - flow.Width / 2, 0);
            flow.FlowDirection = FlowDirection.TopDown;
            //flow.AutoSize = true;
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flow);

            if (numericQ1.Value !=0) 
            {
                for (int i = 0;  i < numericQ1.Value; i++)
                {
                    numberQ++;
                    Panel panel = new Panel();
                    panel.Size = new Size(flow.Width, 100);
                    questionNumber(panel);
                    question(panel);
                    shortAnswer(panel);
                    panelList.Add(panel);
                    flow.Controls.Add(panel);
                }
            }

            if (numericQ3.Value != 0)
            {
                for (int i = 0; i < numericQ3.Value; i++)
                {
                    numberQ++;
                    Panel panel = new Panel();
                    panel.Size = new Size(flow.Width, 100);
                    questionNumber(panel);
                    question(panel);
                    yesno(panel);
                    panelList.Add(panel);
                    flow.Controls.Add(panel);
                }
            }
        }

        private void yesno(Panel p)
        {
            int posX = 80;
            for(int i = 0; i < 2; i++)
            {
                RadioButton r = new RadioButton();
                r.Size = new Size(70, 30);
                r.Location = new Point(0 + posX*i, 70);
                if (i == 0) r.Text = "JA";
                else r.Text = "NEJ";
                p.Controls.Add(r);
            }
        }

        private void questionNumber(Panel p)
        {
            Label label = new Label();
            label.Text = "Fråga " + numberQ;
            p.Controls.Add(label); 
        }

        private void question(Panel p)
        {
            TextBox questionText = new TextBox();
            questionText.Size = new Size(400, 30);
            questionText.Location = new Point(0, 30);
            questionText.Text = "Write your question here";
            p.Controls.Add(questionText);  
        }

        private void shortAnswer(Panel p)
        {
            TextBox questionText = new TextBox();
            questionText.Size = new Size(400, 30);
            questionText.Location = new Point(0, 70);
            questionText.Text = "Write your answer here";
            p.Controls.Add(questionText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}