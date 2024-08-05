namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DangNhapForm());
            //Application.Run(new InHoaDonForm());
        }
    }
}