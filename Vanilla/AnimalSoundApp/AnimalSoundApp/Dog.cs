using System.Windows.Forms;

public class Dog: Animal, ISound
{
    public override string Type => "Dog";   // Specific type for Dog
    public void MakeSound()
    {
        MessageBox.Show("Woof! Woof!"); // Dog's unique sound
    }
}