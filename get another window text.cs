IntPtr hwnd = FindWindow(null, "计算器");
            if (hwnd != IntPtr.Zero)
            {
                IntPtr hwnd1 = FindWindowEx(hwnd, 0, "CalcFrame", ""); //获取 的句柄
                if (hwnd1 != IntPtr.Zero)
                {
                    IntPtr hwnd12 = FindWindowEx(hwnd1, 0, "#32770", ""); //获取 的句柄
                    if (hwnd12 != IntPtr.Zero)
                    {
                        IntPtr hwnd123 = FindWindowEx(hwnd12, 0x100a88, "Static", null); //获取 的句柄
                        if (hwnd123 != IntPtr.Zero)
                        {
                            StringBuilder strB = new StringBuilder(100);
                            SendMessage(hwnd123, WM_GETTEXT, new IntPtr(255), strB);
                            string a = strB.ToString().Trim();
                            MessageBox.Show(a);
                        }
                    }
                }
           }
