using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.Core;
using hardware;
using console_graphics_engine;




namespace CosmosKernel1
{
   
    public class Kernel : Sys.Kernel
    {

        internal DisplayDriver display;
        internal cgecore cge;
        

        protected override void BeforeRun()
        {
            
            //show boot measage and clear screen
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
            Console.WriteLine("TACHYON 2.0--BUILD 2");

            Console.Clear();
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                        ///////////////                                         ");
            Console.WriteLine("                            //////                                              ");
            Console.WriteLine("                            /////                                              ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                        ///////////////                                         ");
            Console.WriteLine("                            //////                                              ");
            Console.WriteLine("                            /////                                              ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////                   /////////////////////////////////////////////////");
            Console.WriteLine("////                   /////////////////////////////////////////////////");
            Console.WriteLine("//////////     ////////////// TACHYON OS 2.0 ///////////////////////////");
            Console.WriteLine("//////////     ///////////// BUILD 100 REV 0 DEV ///////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("///// COPYRIGHT 2017 THE TACHYON PROJECT ///////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////// DEV BUILD- 100.0/////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");





            // pass system(1.1)
            Console.Write("enter passcode  ");
            var input = Console.ReadLine();
            if (input == "tachyon")
            {
                Console.WriteLine("welcome");
                Console.Clear();
                mainrunbypass();
                while (true)
                {
                    var i = 0;
                    i = 1;
                }


            }
            else
            {
                Console.WriteLine("incorrect passcode");
                Console.WriteLine("rebooting session....");
                Cosmos.System.Power.Reboot();
            }
           

        }

        
        public void mainrunbypass()
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("main os...... build 12.3");
            
            display = new DisplayDriver();
            display.init();

            //////////////////////////////////////////////
            
            //draw mouse
            display.draw_mouse();
            ///////////////////////////////////////////////
            
           
            
            
            
           

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        protected override void Run()
        {


         

        }

        public void taskbar_draw_and_check()
        {
            while (true)
            {
                for (uint w = 0; w < 320; w++)
                {

                    for (uint h = 0; h < 30; h++)
                    {

                        uint x = w;

                        uint y = 170 - h;

                        display.setPixel((int)x, (int)y, 30); //SetPixel(x,y,color)

                    }
                }

            }
        }

        public void boot() {
            Console.Clear();
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                        ///////////////                                         ");
            Console.WriteLine("                            //////                                              ");
            Console.WriteLine("                            /////                                              ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                        ///////////////                                         ");
            Console.WriteLine("                            //////                                              ");
            Console.WriteLine("                            /////                                              ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                       Ta                                                       ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                        ///////////////                                         ");
            Console.WriteLine("                            //////                                              ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                       Tach                                                     ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                        ///////////////                                         ");
            Console.WriteLine("                            //////                                              ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                            /////                                               ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                       Tachyon os 2.0                                           ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                                                                ");


            bootend();
        }
        public void bootend() {
            Console.Clear();
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////                   /////////////////////////////////////////////////");
            Console.WriteLine("////                   /////////////////////////////////////////////////");
            Console.WriteLine("//////////     ////////////// TACHYON OS 2.0 ///////////////////////////");
            Console.WriteLine("//////////     ///////////// BUILD 42 REV 8 DEV ////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("//////////     /////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("///// COPYRIGHT 2017 THE TACHYON PROJECT ///////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////// DEV BUILD- 50.0 /////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");

        }




    }





    }

