using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Data;
using System.Drawing.Imaging;
using System.Configuration;


namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accept_Click(object sender, EventArgs e)
        {

            //metodo para generacion de codigo
            String codigo = confirmacion();

            //las consultas usadas 
            String obteneridcliente = "select max(idcliente) from informacion;";

            //string de conexion a base de datos con informacion necesaria 
            String dataconnection = "server=localhost;user id=diracspace;password=roberto33498;database=basededatos2";
            
            //objetos tipo mysql para mandar informacion a base de datos
            MySqlConnection databaseconnection = new MySqlConnection(dataconnection);

            //string de consulta de mysql
            String insertarinformacion = "insert into basededatos2.informacion(nomcliente,primeroA,segundoA,edad,correo,ruta, verify) values ('" + this.nombre.Text + "','" + this.primerA.Text + "','" + segundoA.Text + "','" + this.edad.Text + "','" + this.destino.Text + "','" + this.ruta.Text + "','"+codigo+"');";
            MySqlCommand databasecommand = new MySqlCommand(insertarinformacion, databaseconnection);

            //objetos tipo mysql para mandar una consulta a base de datos
            MySqlConnection conectarmysql = new MySqlConnection(dataconnection);
            MySqlCommand obtenerdatos = new MySqlCommand(obteneridcliente, conectarmysql);

            //objeto tipo mysql para obtener una sesion de lectura
            MySqlDataReader reading;

            try
            {

                //abro mi base de datos
                databaseconnection.Open();
                conectarmysql.Open();

                //ejecuto mi consulta
                reading = databasecommand.ExecuteReader();

                MessageBox.Show("Almacenado, enviando correo ...");

                //obtengo mi id recien agregada
                int id = Convert.ToInt32(obtenerdatos.ExecuteScalar());

                //metodo para el correo
                envio(codigo);

                //muestro el id
                idcliente.Text = id.ToString();

                //metodo para almacenado de imagenes 
                fotos(id);

                //muestro un cuadro de dialogo 
                DialogResult respuesta = MessageBox.Show("Asegúrate de aprenderte tu ID", "ID", MessageBoxButtons.YesNo);

                //borro la informacion si ya dio clic
                if (respuesta == DialogResult.Yes)
                {
                    //elimino la informacion de las cajas
                    idcliente.Clear();
                    nombre.Clear();
                    primerA.Clear();
                    segundoA.Clear();
                    edad.Clear();
                    destino.Clear();
                    ruta.Clear();
                    
                    //
                    Graphics graphic = Graphics.FromImage(imagen.Image);
                    graphic.Clear(Color.Black);
                    imagen.Refresh();
                }
                else
                {
                    MessageBox.Show("No dió click");
                }

                //cierro las conexiones de base de datos
                databaseconnection.Close();
                conectarmysql.Close();

                //cierro el objeto de consultas
                reading.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private String confirmacion()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            string input = "_!#%/+*-'¿?,></$&)(=abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOP0123456789";
            return new string(Enumerable.Range(0, 10).Select(x => input[rand.Next(0, input.Length)]).ToArray());
        }
        private void envio(String codigo)
        {
            //nota, configurar el correo de origen para aceptar envio de terceros

            //preparo los objetos 
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            //correo de destino se obtiene y guarda en destination, y especifico el origen para usar el metodo direccion correo(origen)
            String destination = destino.Text.ToString(), origen = "jaysonisjohnnysins@gmail.com";

            //especifico el origen y su destino
            mail.From = new MailAddress(origen);
            mail.To.Add(destination);

            //diseño del correo a mandar
            mail.Subject = "Confirmación de correo";
            mail.Body = "Este es su código de confirmación de cuenta, asegúrese de ingresarlo en el sistema: " + codigo;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            //especifico el puerto en donde trabajara el objeto stmp client
            SmtpServer.Port = 587;

            //asigno las credenciales para validar el uso del correo origen
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jaysonisjohnnysins@gmail.com", "Roberto_69");
            SmtpServer.EnableSsl = true;

            //envio y despues confirmo el envio. Finalmente cierro el objeto mensaje correo
            SmtpServer.Send(mail);
            MessageBox.Show("Se envío el correo de confirmación");
            mail.Dispose();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            //string de conexion a base de datos con informacion necesaria 
            String dataconnection = "server=localhost;user id=diracspace;password=roberto33498;database=basededatos2";
            String buscardatos = "select nomcliente, primeroA, segundoA, edad, correo, ruta, truth from informacion where idcliente= '" + idcliente.Text + "';";

            //objetos tipo mysql para mandar una consulta a base de datos
            MySqlConnection conectarmysql = new MySqlConnection(dataconnection);
            MySqlCommand obtenerdatos = new MySqlCommand(buscardatos, conectarmysql);

            //objeto para hacer la consulta
            MySqlDataReader reading;

            try
            {
                //abro mi conexion a base de datos
                conectarmysql.Open();

                //envio mi consulta
                reading = obtenerdatos.ExecuteReader();

                //obtengo el id del cliente registrado para hacer 
                //la busqueda de la imagen por id
                String id = this.idcliente.Text;

                while (reading.Read())
                {
                    nombre.Text = (reading["nomcliente"].ToString());
                    primerA.Text = (reading["primeroA"].ToString());
                    segundoA.Text = (reading["segundoA"].ToString());
                    edad.Text = (reading["edad"].ToString());
                    destino.Text = (reading["correo"].ToString());
                    destino.Text = (reading["correo"].ToString());
                    ruta.Text = (reading["ruta"].ToString());
                    clientcode.Text = (reading["truth"].ToString());

                    //el metodo para mostrar imagen despues de encontrarla
                    imagen.Image = System.Drawing.Image.FromFile("D:/Profe Roberto/Registration/Registration/imagenes/imagen"+id);

                    if (clientcode.Text.Equals("False"))
                    {
                        MessageBox.Show("No ingresó su código de Activación");
                    }

                    MessageBox.Show("Se encontró la información");
                }
                reading.Close();
                conectarmysql.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo agregar nuevo usuario");
            }
        }
        private void fotos(int id)
        {
            try 
            {
                //string para identificar las imagenes mediante el id recien registrado
                String idimagen = id.ToString();

                //ruta predeterminada de almacenamiento con la id que ingrese el cliente
                String rutaarchivo = "D:/usb backup/Profe Roberto/Registration/Registration/imagenes/imagen" + idimagen;

                imagen.Image.Save("D:/usb backup/Profe Roberto/Registration/Registration/imagenes/imagen"+idimagen, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch 
            {
                MessageBox.Show("No se puede guardar la imagen");
            }
        }
        private void deletefotos(int id) 
        {
            try
            {
                //string para identificar las imagenes mediante el id recien registrado
                String idimagen = id.ToString();

                //ruta predeterminada de almacenamiento con la id que ingrese el cliente
                String rutaarchivo = "D:/usb backup/Profe Roberto/Registration/Registration/imagenes/imagen" + idimagen;

                System.IO.File.Delete(rutaarchivo);
                fotos(id);
            }
            catch 
            {
 
            }
        }
        
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editar_Click(object sender, EventArgs e)
        {

            String actualizarinfo = "update informacion set nomcliente = '"+nombre.Text+"', primeroA = '"+primerA.Text+"', segundoA = '"+segundoA.Text+"', edad = '"+edad.Text+"', ruta = '"+ruta.Text+"' where idcliente= '"+idcliente.Text+"';";
            String compararpass = "select verify from informacion where idcliente = '"+this.idcliente.Text+"';";
            String updatetruth = "update informacion set truth = 1 where idcliente = '"+this.idcliente.Text+"';";

            String dataconnection = "server=localhost;user id=diracspace;password=roberto33498;database=basededatos2";
            MySqlConnection databaseconnection = new MySqlConnection(dataconnection);
            MySqlConnection verificar = new MySqlConnection(dataconnection);
            MySqlConnection actualizar = new MySqlConnection(dataconnection);

            MySqlCommand databasecommand = new MySqlCommand(actualizarinfo, databaseconnection);
            MySqlCommand comparacion = new MySqlCommand(compararpass, verificar);
            MySqlCommand newtruth = new MySqlCommand(updatetruth, actualizar);

            MySqlDataReader reading1, reading2, reading3;

            try
            {

                databaseconnection.Open();
                verificar.Open();
                actualizar.Open();

                //obtengo mi id recien agregada
                int id = Convert.ToInt32(idcliente.Text);

                reading1 = comparacion.ExecuteReader();
                reading2 = newtruth.ExecuteReader();
                reading3 = databasecommand.ExecuteReader();

                while(reading1.Read()){
                    String comprobacion = (reading1["verify"].ToString());

                    if (clientcode.Text.Equals(comprobacion))
                    {
                        MessageBox.Show("¡Se activó su cuenta!");
                    }
                }

                deletefotos(id);

                //elimino la informacion de las cajas
                idcliente.Clear();
                nombre.Clear();
                primerA.Clear();
                segundoA.Clear();
                edad.Clear();
                destino.Clear();
                ruta.Clear();
                clientcode.Clear();

                //regresar el picturebox a vacio
                Graphics graphic = Graphics.FromImage(imagen.Image);
                graphic.Clear(Color.Black);
                imagen.Refresh();

                reading1.Close();
                reading2.Close();
                reading3.Close();

                databaseconnection.Close();
                verificar.Close();
                actualizar.Close();
            }
            catch
            {
                MessageBox.Show("No se logró actualizar");
            }
        }

        private void imagen_Click(object sender, EventArgs e)
        {
            try
            {
                //abro un dialogo de busqueda
                OpenFileDialog archivo = new OpenFileDialog();

                //creo un filtro de tipo de extensiones que quiero
                archivo.Filter = "Image files | *.jpg";

                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    //guardo la ruta
                    ruta.Text = archivo.FileName;

                    //muestro la imagen
                    imagen.Image = Image.FromFile(archivo.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Error de imagen");
            }
        }
        private void guardar_Click(object sender, EventArgs e)
        {

        }
        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbbackup_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            String databaseconnection = "server=localhost;user id=diracspace;password=roberto33498;database=basededatos2";
            String archivo = "F:/usb backup/Profe Roberto/Registration/Registration/respaldosbase/respaldo.txt";
            String encryptado = "F:/usb backup/Profe Roberto/Registration/Registration/respaldosbase/respaldoencriptado.txt";
            String password = "fuckyou";

            using (MySqlConnection conn = new MySqlConnection(databaseconnection))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        if (File.Exists(@encryptado))
                        {
                            File.Delete(@encryptado);

                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(@archivo);
                            mb.EncryptDumpFile(@archivo, @encryptado, @password);
                            File.Delete(@archivo);
                            conn.Close();
                            MessageBox.Show("Se borró respaldo anterior y se generó otro en esta hora " + now.ToString("T"));
                        }
                        else
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(@archivo);
                            mb.EncryptDumpFile(@archivo, @encryptado, @password);
                            File.Delete(@archivo);
                            conn.Close();
                            MessageBox.Show("No había respaldo, así que se realizó un respaldo a esta hora " + now.ToString("T"));
                        }
                    }
                }
            }
        }

        private void bdview_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

            try
            {
                DateTime now = DateTime.Now;

                String archivo = "F:/usb backup/Profe Roberto/Registration/Registration/respaldosbase/respaldo.txt";
                String encryptado = "F:/usb backup/Profe Roberto/Registration/Registration/respaldosbase/respaldoencriptado.txt";
                String password = "fuckyou";
                String input = myForm.inputpasswrd;

                if (password.Contains(input))
                {
                    MySqlBackup mb = new MySqlBackup();

                    MessageBox.Show("Se desencriptó el respaldo en esta hora " + now.ToString("T"));
                    mb.DecryptDumpFile(@encryptado, @archivo, @input);
                }
                else
                {
                    MessageBox.Show("No es la misma contraseña");
                }
            }
            catch
            {
                MessageBox.Show("No se recibió contraseña");
            }
        }
    }
}