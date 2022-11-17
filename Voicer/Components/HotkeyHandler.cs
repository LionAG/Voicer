using System.Runtime.InteropServices;

namespace Voicer.Components
{
    internal class HotKeyHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int Key = 0;
        private int Modifiers = 0;
        private int Identifier = 0;
        private IntPtr WindowHandle = IntPtr.Zero;

        public HotKeyHandler(Form form, Keys key)
        {
            Key = (int)key;
            WindowHandle = form.Handle;
            Identifier = GetHashCode();
        }

        public HotKeyHandler(Form form, Keys key, int modifiers)
        {
            Key = (int)key;
            Modifiers = modifiers;
            WindowHandle = form.Handle;
            Identifier = GetHashCode();
        }

        public override int GetHashCode()
        {
            return Key ^ WindowHandle.ToInt32();
        }

        public bool Register()
        {
            return RegisterHotKey(WindowHandle, Identifier, Modifiers, Key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(WindowHandle, Identifier);
        }
    }
}
