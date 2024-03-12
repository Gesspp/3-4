namespace Arrays;

internal abstract class bArray : IBaseArray
{
    public bArray(bool fillByUser) {};
    abstract public void Print();
    abstract protected void userArray();
    abstract protected void randomArray();

}