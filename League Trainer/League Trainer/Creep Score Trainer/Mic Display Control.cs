using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_Trainer.Creep_Score_Trainer
{
    public partial class Mic_Display_Control : UserControl
    {
        [Description("Gets or sets the state of this control"),Category("Display Elements")]
        public circleColor state
        {
            get { return currentState; }
            set {
                currentState = value;
                setCircle(value); }
        }

        private circleColor currentState = circleColor.Red;

        Image displayCircle = new Bitmap(32, 32);

        public enum circleColor
        {
            Red=0,
            Yellow=1,
            Green=3
        }

        public Mic_Display_Control()
        {
            InitializeComponent();
        }

        private void setCircle(circleColor newColor)
        {
            switch (newColor)
            {
                case global::League_Trainer.Creep_Score_Trainer.Mic_Display_Control.circleColor.Red:
                    redrawCircle(Color.Red);
                    break;
                case global::League_Trainer.Creep_Score_Trainer.Mic_Display_Control.circleColor.Yellow:
                    redrawCircle(Color.Yellow);
                    break;
                case global::League_Trainer.Creep_Score_Trainer.Mic_Display_Control.circleColor.Green:
                    redrawCircle(Color.Green);
                    break;
                default:
                    break;
            }
        }
        
        private void redrawCircle(Color circleColor)
        {
            using (Graphics g = Graphics.FromImage(displayCircle))
            {
                Pen g_pen = new Pen(circleColor);
                g.FillEllipse(g_pen.Brush, 0, 0, 32, 32);
            }

            pictureBox1.Image = displayCircle;
        }
    }
}
