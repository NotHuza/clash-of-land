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
                            break;
                        }

                    // Status
                    case ConsoleKey.S:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("#" + DateTime.Now.ToString("d") + " ---- STATS ---- " +
                                              DateTime.Now.ToString("T") + " #");
                            Console.WriteLine("# -------------------------------------- #");
                            Console.WriteLine("# In-Memory Players    # " +
                                              Utils.Padding(Players.Levels.Count.ToString(), 15) + " #");
                            Console.WriteLine("# In-Memory Battles    # " +
                                              Utils.Padding(Resources.Battles.Seed.ToString(), 15) + " #");
                            Console.WriteLine("# -------------------------------------- #");
                            break;
                        }

                    case ConsoleKey.M:
                        {
                            if (Resources.Classes.Timers.LTimers.Count <= 3)
                            {
                                Console.WriteLine("Press Y to continue and N to cancle");
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
                                            Console.WriteLine("Press Y to continue and N to cancle");
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
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("# " + DateTime.Now.ToString("d") + " ---- HELP ---- " +
                                              DateTime.Now.ToString("T") + " #");
                            Console.WriteLine("# ------------------------------------- #");
                            Console.WriteLine(((IEnumerable)Process.GetCurrentProcess().Threads)
                                .OfType<ProcessThread>()
                                .Count(t => t.ThreadState == ThreadState.Running));
                            Console.WriteLine("# --------S - Status------------------- #");
                            Console.WriteLine("# --------M - Maintenace Mode---------- #");
                            Console.WriteLine("# --------D - Exit Maintenance--------- #");
                            Console.WriteLine("# --------C - Clear Screen------------- #");
                            Console.WriteLine("# --------T - Restart Timer------------ #");
                            Console.WriteLine("# ------F10 - GUI---------------------- #");
                            Console.WriteLine("# --------E - Exit Server-------------- #");
                            Console.WriteLine("# ------------------------------------- #");
                            Console.WriteLine("# -----------In Game Commands---------- #");
                            Console.WriteLine("# ------------------------------------- #");
                            Console.WriteLine("# -/resource (0-3:TH - 7,8:BB - 9:ALL)- #");
                            Console.WriteLine("# -/max_village (0-2:0-TH,1-BB,2-BOTH)- #");
                            Console.WriteLine("# -/stats - Statistics of a player----- #");
                            Console.WriteLine("# -/clone - clone a players base------- #");
                            Console.WriteLine("# -/rank - Create/Edit Server Ranks---- #");
                            Console.WriteLine("# --(/rank is for Server Owners Only)-- #");
                            Console.WriteLine("# ------------------------------------- #");
                            Console.WriteLine("# ------------------------------------- #");
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
                            break;
                        }

                    case ConsoleKey.T:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("# " + DateTime.Now.ToString("d") + " ---- ReStart Timer Activated ---- " +
                            DateTime.Now.ToString("T") + " #");
                            Process ExternalProcess = new Process();
                            ExternalProcess.StartInfo.FileName = "CLS.bat";
                            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            ExternalProcess.Start();
                            ExternalProcess.WaitForExit();
                            break;
                        }



                    case ConsoleKey.F10:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("# " + DateTime.Now.ToString("d") + " ---- ClashLand GUI Mode ---- " +
                            DateTime.Now.ToString("T") + " #");
                            Process ExternalProcess = new Process();
                            Application.Run(new ClashLandGUI2());
                            break;
                        }
                        
                        

                }

                Console.ResetColor();
            }
        }
    }
}
