using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel;

namespace WinFormsAppKhee
{
    public class ButtonRedondo : Button
    {
        private int borderSize = 0;
        private int borderRadius = 30;
        private Color borderColor = Color.Transparent;

        //propiedades
        [Category("ButtonRound")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate(); //dibuja el boton de nuevo
            }
        }
        [Category("ButtonRound")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("ButtonRound")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("ButtonRound")]
        public Color BackgroundColor
        {
            get => BackColor;
            set
            {
                this.BackColor = value;
            }
        }
        [Category("ButtonRound")]
        public Color TextColor
        {
            get => ForeColor;
            set
            {
                this.ForeColor = value;
            }
        }

        //Constructor
        public ButtonRedondo()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;     //tamaño del borde del boton
            this.Size = new Size(100, 100);      //tamaño del boton
            this.BackColor = Color.Black;     //color de fondo del boton
            this.ForeColor = Color.White;       //color de las letras del boton 
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath(); //objeto de graficos
            path.StartFigure(); //se inicia la figura de la ruta
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);    //arco en el eje inicial
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);    //arco en la esquina superior derecha
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);    //arco en la esquina inferior derecha
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);    //arco en la esquina inferior izquierda
            path.CloseFigure();

            return path;

        }
        protected override void OnPaint(PaintEventArgs e) // Se crea para ampliar la funcionalidad
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height); // Superficie exterior del botón
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1); // Borde del botón

            if (borderRadius > 2) // Botón con esquinas redondeadas
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Center;
                    // Superficie del botón
                    this.Region = new Region(pathSurface);
                    // Dibujar el borde de la superficie
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    // Borde del botón
                    if (borderSize >= 1)
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
