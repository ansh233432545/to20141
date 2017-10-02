using Cosmos.HAL;
using Sys = Cosmos.System;
using System;

namespace hardware
{
   public class DisplayDriver
    {
       
        public VGAScreen VScreen;
        public Mouse m = new Mouse();
        private int width, height;
        public static VGAScreen VVScreen = new VGAScreen();
        public static byte[] SBuffer = new byte[64000];
        
        
        
        public DisplayDriver()
        {
            VScreen = new VGAScreen();
        }

        public static void DrawFilledRectangle(uint x0, uint y0, int Width, int Height, int color)
        {
            for (uint i = 0; i < Width; i++)
            {
                for (uint h = 0; h < Height; h++)
                {
                    SetPixel((int)(x0 + i), (int)(y0 + h), color);
                }
            }
        }
        public static void SetPixel(int x, int y, int color)
        {
            SBuffer[(y * 320) + x] = (byte)color;
        }
        public void init()
        {
            VScreen.SetGraphicsMode(VGAScreen.ScreenSize.Size320x200, VGAScreen.ColorDepth.BitDepth8);
            VScreen.Clear((int)ConsoleColor.DarkMagenta);
            width = VScreen.PixelWidth;
            height = VScreen.PixelHeight;
        }

        public virtual void setPixel(int x, int y, int c)
        {
            if (VScreen.GetPixel320x200x8((uint)x, (uint)y) != (uint)c)
                setPixelRaw(x, y, c);
        }

        public virtual byte getPixel(int x, int y)
        {
            return (byte)VScreen.GetPixel320x200x8((uint)x, (uint)y);
        }

        public virtual void clear()
        {
            clear(0);
        }

        public virtual void clear(int c)
        {
            VScreen.Clear(c);
        }

        public virtual void step() { }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public void setPixelRaw(int x, int y, int c)
        {

            VScreen.SetPixel320x200x8((uint)x, (uint)y, (uint)c);

        }


        public void draw_mouse()
        {

            startmenu();
            VScreen.Clear((int)ConsoleColor.Magenta);
            m.Initialize(320, 200);
            while (true)
            {
                
                DrawFilledRectangle(0, 160, 320, 25, 50);
               


                //////////////////////////////////////////
                VScreen.SetPixel((uint)m.X, (uint)m.Y, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X + 1, (uint)m.Y, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X + 2, (uint)m.Y, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X, (uint)m.Y + 1, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X, (uint)m.Y + 2, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X + 1, (uint)m.Y + 1, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X + 2, (uint)m.Y + 2, (int)ConsoleColor.White);
                VScreen.SetPixel((uint)m.X + 3, (uint)m.Y + 3, (int)ConsoleColor.White);
               
            
                


                    startmenu();



               

                ReDraw();


                ///////////////////////////////////////////
            }
        }


        public static void startmenu()
        {

            DrawFilledRectangle(0, 0, 25, 120, 50);
            DrawFilledRectangle(5, 10, 20, 20, (int)ConsoleColor.DarkGray);


        }



        public static void ReDraw()
        {
            // VVScreen.Clear(0);

            int c = 0;

            for (int y = 0; y < 200; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    uint cl = VVScreen.GetPixel320x200x8((uint)x, (uint)y);
                    if (cl != (uint)SBuffer[c])
                    {
                        VVScreen.SetPixel320x200x8((uint)x, (uint)y, SBuffer[c]);
                    }
                    c++;
                }
            }
            for (int i = 0; i < 64000; i++)
            {
                SBuffer[i] = (int)ConsoleColor.Magenta;
            }
        }




    }







    }

