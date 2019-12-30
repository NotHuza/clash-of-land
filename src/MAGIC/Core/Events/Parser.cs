using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Logic.Structure;
using ClashLand.Packets.Messages.Server.Errors;
using ThreadState = System.Diagnostics.ThreadState;
using ClashLand.Packets.Messages.Server.Authentication;
using ClashLand.Logic.Enums;
using System.Windows.Forms;
using ClashLandGUI;
using System.Drawing;

namespace ClashLand.Core.Events
{
    internal class Parser
    {
        internal Thread Thread;
        

        internal Parser()
        {
            this.Thread = new Thread(this.Parse)
            {
                Priority = ThreadPriority.Lowest,
                Name = this.GetType().Name
            };
            this.Thread.Start();
        }

        internal void Parse()
        {
            while (true)
            {
                ConsoleKeyInfo Command = Console.ReadKey(false);

                switch (Command.Key)
                {
                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Press H for help");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                    // Status
                    case ConsoleKey.S:
                        {
                            Console.Clear();
                            Console.WriteLine(Environment.NewLine);
                            Consoles.Colorful.Console.Write("                                   # " + DateTime.Now.ToString("d") + " ---- STATS ---- " +
                                              DateTime.Now.ToString("T") + "  #", Color.LawnGreen);
                            Console.WriteLine(Environment.NewLine);
                            Consoles.Colorful.Console.Write("                                   # -------------------------------------- #", Color.LawnGreen);
                            Console.WriteLine(Environment.NewLine);
                            Consoles.Colorful.Console.Write("                                   # In-Memory Players    # " +
                                              Utils.Padding(Players.Levels.Count.ToString(), 15) + " #", Color.LawnGreen);
                            Console.WriteLine(Environment.NewLine);
                            Consoles.Colorful.Console.Write("                                   # In-Memory Battles    # " +
                                              Utils.Padding(Resources.Battles.Seed.ToString(), 15) + " #", Color.LawnGreen);
                            Console.WriteLine(Environment.NewLine);
                            Consoles.Colorful.Console.Write("                                   # -------------------------------------- #", Color.LawnGreen);
                            Console.WriteLine(Environment.NewLine);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                    case ConsoleKey.M:
                        {
                            if (Resources.Classes.Timers.LTimers.Count <= 3)
                            {
                                Console.WriteLine("Press Y to continue and N to cancel");
                                ConsoleKeyInfo Command2 = Console.ReadKey(false);

                                switch (Command2.Key)
                                {
                                    case ConsoleKey.Y:
                                        {
                                            Console.WriteLine(
                                                "Please enter the duration of Maintenance (Enter value in int only).");
                                            Console.Write("(Minute): ");
                                            int i = 0;
                                            if (Int32.TryParse(Console.ReadLine(), out i))
                                            {
                                                Resources.Classes.Timers.Maintenance(i);
                                                Resources.Classes.Timers.LTimers[4].Start();
                                            }
                                            else
                                                Console.WriteLine("Value is invalid, Request cancelled");
                                            break;
                                        }

                                    case ConsoleKey.N:
                                        {
                                            Console.WriteLine("Request cancelled");
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Press Y to continue and N to cancel");
                                            break;
                                        }
                                }
                            }
                            else
                            {

                                Console.WriteLine("# " + DateTime.Now.ToString("d") +
                                                  " ---- Server is already in Maintanance Mode---- " +
                                                  DateTime.Now.ToString("T") +
                                                  " #");
                            }
                            break;
                        }

                    case ConsoleKey.D:
                        {
                            if (Constants.Maintenance != null)
                            {
                                Constants.Maintenance = null;
                                Resources.Classes.Timers.LTimers[4].Stop();
                                Resources.Classes.Timers.LTimers[5].Stop();
                                Resources.Classes.Timers.LTimers.Remove(4);
                                Resources.Classes.Timers.LTimers.Remove(5);
                                Console.WriteLine("# " + DateTime.Now.ToString("d") +
                                                  " ---- Exited from Maintanance Mode---- " + DateTime.Now.ToString("T") +
                                                  " #");
                            }
                            else
                            {
                                Console.WriteLine("# " + DateTime.Now.ToString("d") +
                                                  " ---- Not in Maintanance Mode---- " + DateTime.Now.ToString("T") +
                                                  " #");
                            }
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                    // Emergency Close
                    case ConsoleKey.E:
                        {
                            Environment.Exit(0);
                            break;
                        }

                    case ConsoleKey.H:
                        {
                            Console.Clear();
                            Console.ResetColor();
                            Console.SetOut(new Prefixed());
                            Console.SetBufferSize(System.Console.WindowWidth, System.Console.WindowHeight);
                            Console.WriteLine(Environment.NewLine);
                            //Console.ForegroundColor = ConsoleColor.Blue;
                            Consoles.Colorful.Console.Write(@"

                                                    /---- HELP ----\
                                       # ----------/----------------\--------- #
                                       # --------S - Status------------------- #
                                       # --------M - Maintenace Mode---------- #
                                       # --------D - Exit Maintenance--------- #
                                       # --------C - Clear Screen------------- # 
                                       # --------T - Restart Timer------------ #
                                       # ------F10 - GUI---------------------- #
                                       # --------E - Exit Server-------------- #
                                       # ------------------------------------- #
                                       # -----------In Game Commands---------- #
                                       # ------------------------------------- #
                                       # -/resource (0-3:TH - 7,8:BB - 9:ALL)- #
                                       # -/max_village (0-2:0-TH,1-BB,2-BOTH)- #
                                       # -/stats - Statistics of a player----- #
                                       # -/clone - clone a players base------- #
                                       # -/discordmsg - sends discord msg----- #
                                       # -/rank - Create/Edit Server Ranks---- #
                                       # --(/rank is for Server Owners Only)-- #
                                       # ------------------------------------- #
                            ", Color.BlueViolet);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        }

                    case ConsoleKey.R:
                        {
                            foreach (var _Device in Devices._Devices.Values.ToList())
                            {
                                if (_Device.Player != null)
                                {
                                    new Authentication_Failed(_Device) { Reason = (Reason)14 }.Send();
                                }
                                
                            }
                            break;
                        }

                    case ConsoleKey.C:
                        {
                            Console.Clear();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                    case ConsoleKey.T:
                        {
                            Console.Clear();
                            Console.ResetColor();
                            //Console.ForegroundColor = ConsoleColor.Green;
                            Consoles.Colorful.Console.WriteLine("# " + DateTime.Now.ToString("d") + " ---- ReStart Timer Activated ---- " +
                            DateTime.Now.ToString("T") + " #", Color.Gainsboro);
                            Process ExternalProcess = new Process();
                            ExternalProcess.StartInfo.FileName = "CLS.bat";
                            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            ExternalProcess.Start();
                            ExternalProcess.WaitForExit();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }



                    case ConsoleKey.F10:
                        {
                            Console.Clear();
                            Console.ResetColor();
                            //Console.ForegroundColor = ConsoleColor.Blue;
                            Consoles.Colorful.Console.WriteLine("# " + DateTime.Now.ToString("d") + " ---- ClashLand GUI Mode ---- " +
                            DateTime.Now.ToString("T") + " #", Color.BlueViolet);
                            Process ExternalProcess = new Process();
                            Application.Run(new ClashLandGUI2());
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                        
                        

                }

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
