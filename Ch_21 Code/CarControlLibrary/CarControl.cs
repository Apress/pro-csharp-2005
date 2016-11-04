using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CarControlLibrary
{
    public enum AnimFrames
    {
        Lemon1, Lemon2, Lemon3,
        AboutToBlow, EngineBlown
    }

    [DefaultEvent("AboutToBlow"), 
    DefaultProperty("Animate"),
    ToolboxBitmap(typeof(CarControl), "CarControl")]
    public partial class CarControl : UserControl
    {
        // State data.
        private AnimFrames currFrame = AnimFrames.Lemon1;
        private AnimFrames currMaxFrame = AnimFrames.Lemon3;
        private bool IsAnim;
        private int currSp = 50;
        private int maxSp = 100;
        private string carPetName = "Lemon";
        private Rectangle bottomRect = new Rectangle();

        // Car events / custom delegate.
        public delegate void CarEventHandler(string msg);

        [Category("Car Configuration"),
        Description("Sent when the car is approaching terminal speed.")]
        public event CarEventHandler AboutToBlow;
        [Category("Car Configuration"),
        Description("Sent when the engine block has exploded.")]
        public event CarEventHandler BlewUp;

        public CarControl()
        {
            InitializeComponent();
            StretchBox();
        }

        #region Helper function
        private void StretchBox()
        {
            // Configure picture box.
            currentImage.Top = 0;
            currentImage.Left = 0;
            currentImage.Height = this.Height - 50;
            currentImage.Width = this.Width;
            currentImage.Image =
                carImages.Images[(int)AnimFrames.Lemon1];
            // Figure out size of bottom rect.
            bottomRect.X = 0;
            bottomRect.Y = this.Height - 50;
            bottomRect.Height = this.Height - currentImage.Height;
            bottomRect.Width = this.Width;
        }
        #endregion 

        #region Event Handlers
        private void imageTimer_Tick(object sender, EventArgs e)
        {
            if (IsAnim)
                currentImage.Image = carImages.Images[(int)currFrame];
            // Bump frame.
            int nextFrame = ((int)currFrame) + 1;
            currFrame = (AnimFrames)nextFrame;
            if (currFrame > currMaxFrame)
                currFrame = AnimFrames.Lemon1;
        }

        private void CarControl_Paint(object sender, PaintEventArgs e)
        {
            // Render the petname on the bottom of the control.
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.GreenYellow, bottomRect);
            g.DrawString(PetName, new Font("Times New Roman", 15),
                Brushes.Black, bottomRect);
        }
        #endregion

        #region Properties
        [Category("Car Configuration"),
        Description("Do you want to animate?"),
        DefaultValue("false")]
        public bool Animate
        {
            get { return IsAnim; }
            set
            {
                IsAnim = value;
                imageTimer.Enabled = IsAnim;
            }
        }
        // Configure pet name.
        [Category("Car Configuration"),
        Description("Name your car!"),
        DefaultValue("Lemon")]
        public string PetName
        {
            get { return carPetName; }
            set
            {
                carPetName = value;
                Invalidate();
            }
        }
        // Adjust currSp, currMaxFrame and fire our events.
        [Category("Car Configuration"),
        Description("Speed of the car"),
        DefaultValue("50")]
        public int Speed
        {
            get { return currSp; }
            set
            {
                if (currSp <= maxSp)
                {
                    currSp = value;
                    currMaxFrame = AnimFrames.Lemon3;
                }
                // About to explode?
                if ((maxSp - currSp) <= 10)
                {
                    if (AboutToBlow != null)
                    {
                        AboutToBlow("Slow down dude!");
                        currMaxFrame = AnimFrames.AboutToBlow;
                    }
                }
                // Maxed out?
                if (currSp >= maxSp)
                {
                    currSp = maxSp;
                    if (BlewUp != null)
                    {
                        BlewUp("Ug...you're toast...");
                        currMaxFrame = AnimFrames.EngineBlown;
                    }
                }
            }
        }
        #endregion 
    }
}