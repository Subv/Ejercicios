using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SlimDX;
using SlimDX.Direct3D9;
using SlimDX.Windows;

namespace Ejercicios
{
    class MyForm : Form
    {
        private Direct3D d3d;
        private Device device;
        
        public MyForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            d3d = new Direct3D();
            var pp = new PresentParameters();
            pp.SwapEffect = SwapEffect.Discard;
            pp.DeviceWindowHandle = Handle;
            pp.Windowed = true;
            pp.BackBufferWidth = Width;
            pp.BackBufferHeight = Height;
            pp.BackBufferFormat = Format.A8R8G8B8;

            device = new Device(d3d, 0, DeviceType.Hardware, Handle, CreateFlags.HardwareVertexProcessing, pp);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Render();
        }

        public void Render()
        {
            device.Clear(ClearFlags.Target, new Color4(Color.White), 0, 0);

            device.BeginScene();

            device.VertexFormat = VertexFormat.Position | VertexFormat.Diffuse;

            /*device.DrawUserPrimitives(PrimitiveType.LineList,
                                    ClientSize.Width / 2,
                                    data);*/

            device.EndScene();

            device.Present();
        }
    }

    class _3D
    {
        public void Run()
        {
            var form = new MyForm();
            Application.Run(form);
        }
    }
}
