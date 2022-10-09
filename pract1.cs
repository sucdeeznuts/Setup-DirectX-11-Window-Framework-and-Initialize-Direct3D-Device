using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        Microsoft.DirectX.Direct3D.Device device;
        public Form1()
        {
            InitializeComponent();
            InitDevice();
        }
        

public void InitDevice()
        {
    PresentParameters pp = new PresentParameters();
    pp.Windowed = true;
    pp.SwapEffect = SwapEffect.Discard;
    device = new Device(0, DeviceType.Hardware, this,
                    CreateFlags.HardwareVertexProcessing, pp);
        }

private void Render()
{
    device.Clear(ClearFlags.Target, Color.Orange, 0, 1);
    device.Present();
}

        private void Form1_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }
    }
}
