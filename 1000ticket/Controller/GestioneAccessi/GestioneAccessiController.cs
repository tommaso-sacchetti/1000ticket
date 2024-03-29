﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _1000ticket.Controller.GestioneAccessi
{
    public class GestioneAccessiController
    {
        private int port;
        public GestioneAccessiController()
        {
            //pensare ai parametri del costruttore (IP e porta?)
        }

        Boolean VerificaTitolo(string ID) {

            Boolean result = false;
            string codice = "codice"; //poi vedremo come ottenere il codice dall'interfaccia

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0]; //IPAddress della macchina che sto utilizzando
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000); //

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP); //connette la socket all'IP e porta del server

                    Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                    byte[] msg = Encoding.ASCII.GetBytes(codice); //trasforma in byte la stringa

                    int bytesSent = sender.Send(msg); //invia il messaggio

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes); //riceve risposta
                    Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return result;
        }


        void MostraNotifica(Boolean verifica)
        {
            //mostrare dinamicamente la pagina di notifica notifica
        }
    }
}
