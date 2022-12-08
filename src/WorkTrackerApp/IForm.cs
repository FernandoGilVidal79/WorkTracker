namespace WorkTrackerAPP
{
    public interface IForm
    {       

        void EnviarEstado(string estado);

        int EnviarValueProgressBar(int value);

        void EnviarMaxValueProgressBar(int value);
    }
}