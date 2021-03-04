namespace PizzaBox.Domain.Abstracts
{
    public abstract class AStore
    {
        //Encapsulation how this data is accessed 
        //So we make it private

        public string Name { get; protected set; }//Property

        public override string ToString()
        {
            return Name;
        }
    }
}