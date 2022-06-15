using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Vistas
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Prueba objeto = new Prueba();

            this.label1.Text = objeto.inicio();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Datos = CUsuario.Login(this.txtCorreo.Text, this.txtPass.Text);
            string imprimir = " ";
            if (Datos.Rows.Count==0)
            {
                MensajeError("Datos incorrectos");
            }
           
            else
            {
                // Notificacion desde server sockets
                byte[] bytes = new byte[1024];

                try
                {
                    IPHostEntry host = Dns.GetHostEntry("localhost");
                    IPAddress ipAddress = host.AddressList[0];
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                    Socket sender2= new Socket(ipAddress.AddressFamily,SocketType.Stream, ProtocolType.Tcp);

                    try
                    {
                        // Connect to Remote EndPoint
                        sender2.Connect(remoteEP);

                        Console.WriteLine("Socket connected to {0}",
                            sender2.RemoteEndPoint.ToString());

                        // Encode the data string into a byte array.
                        byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                        // Send the data through the socket.
                        int bytesSent = sender2.Send(msg);

                        // Receive the response from the remote device.
                        int bytesRec = sender2.Receive(bytes);
                        Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                        imprimir = Convert.ToString(Encoding.ASCII.GetString(bytes, 0, bytesRec).ToString());



                    }
                    catch (ArgumentNullException ane)
                    {
                        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    }
                    catch (SocketException se)
                    {
                        Console.WriteLine("SocketException : {0}", se.ToString());
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine("Unexpected exception : {0}", x.ToString());
                    }

                }
                catch (Exception eb)
                {
                    Console.WriteLine(eb.ToString());
                }
             notifyIcon1.Icon = new Icon(Path.GetFullPath(@"C:\Users\KARIME\source\repos\Proyecto\Vistas\imagenes\notificaciones.ico"));
                notifyIcon1.Text = imprimir;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Dashwork";
                notifyIcon1.BalloonTipText = imprimir;
                notifyIcon1.ShowBalloonTip(100);
                // Fin notificacion
               

                

                Form1 Form = new Form1();
                Form.IdUsuario = Datos.Rows[0][0].ToString();
                Form.Apellidos = Datos.Rows[0][2].ToString();
                Form.Nombre = Datos.Rows[0][1].ToString();
                Form.Acceso = Datos.Rows[0][3].ToString();
                Form.Show();
                Hide();
            }
        }
    }
}
