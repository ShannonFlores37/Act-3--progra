using WMPLib;
namespace Act_3__progra
{
    public partial class Form1 : Form
    {
        //objeto que se encargar de reproducir el audio
        private WindowsMediaPlayer reproductor;
        //guarda la ruta del archivo seleccionado
        private string archivoSeleccionado = "";

        public Form1()
        {
            InitializeComponent();
            //creamos el reproductor
            reproductor = new WindowsMediaPlayer();
            //evita que reproduzca un audio
            reproductor.settings.autoStart = false;
            //configuramos el openfile dialog
            openFileDialog1.Filter = "archivos de audio (*.mp3)|*.mp3";
            openFileDialog1.Title = "Selecciona un archivo MP3";


        }



        private void lblarchivo_Click(object sender, EventArgs e)
        {

        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            try
            {
                //si no hay un archivo seleccionado abrimos el explirador de archivos
                if(string.IsNullOrEmpty(archivoSeleccionado))
                {
                    DialogResult resultado=
                        openFileDialog1.ShowDialog();
                    //el usuario ancelo la seleccion
                    if(resultado == DialogResult.OK) {
                        return;

                        //guardar la ruta del archivo lo que selecciono se guarda ahí
                        archivoSeleccionado= openFileDialog1.FileName;
                        //mostramos el nombre del archivo en el label
                        lbla.Text = "archivo seleccionado: " +
                            Path.GetFileName(archivoSeleccionado);
                }
            }catch(Exeption ex)
            {
                MessageBox.Show("Error al abrir el archivo" + ex.Message);
            }
            //indicammos al reproductor que reproduzca 4l archivo seleccionado
            reproductor.URL = archivoSeleccionado;
            //reproducir el sonido
            reproductor.controls.play();
        }
    }
}
