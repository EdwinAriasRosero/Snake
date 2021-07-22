using SnakeConsole;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinForms.Infrastructure
{
    public class Drawer : IDrawer
    {
        private readonly Form1 _control;
        private readonly int _zoom = 10;

        public Drawer(Form1 control)
        {
            _control = control;
        }

        public void Draw(DrawingFixture parent, int left, int top, string symbol)
        {
            if (parent != null)
            {
                if (left < 0 || left >= parent.Location.Width || top >= parent.Location.Height || top < 0)
                {
                    throw new CollisionException("Board");
                }
            }

            var panel = _control.Controls.Find("panel1", true).First() as Panel;

            Rectangle rectangle = new Rectangle(left * _zoom, top * _zoom, _zoom, _zoom);

            if (symbol == "\0")
            {
                SolidBrush eraser = new SolidBrush(Color.Yellow);
                panel.CreateGraphics().FillRectangle(eraser, rectangle);
            }
            else
            {
                SolidBrush pen = new SolidBrush(Color.Red);

                if (symbol == "▒")
                {
                    pen = new SolidBrush(Color.Green);
                }
                
                panel.CreateGraphics().FillRectangle(pen, rectangle);
            }
        }

        public void SetBoardDimension(int width, int height)
        {
            _control.Width = width * _zoom;
            _control.Height = height * _zoom + 100;

            var panel = _control.Controls.Find("panel1", true).First() as Panel;
            panel.BackColor = Color.Yellow;
            panel.Width = width * _zoom;
            panel.Height = height * _zoom;

            _control.Refresh();
        }

        public void SetText(int x, int y, string text)
        {
            _control.Invoke(new Action(() => 
            {
                (_control.Controls.Find("label1", false).First() as Label).Text = text;
            }));
        }
    }
}
