using System.Runtime;

namespace MainProgram.Level2;

public class Developer
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public ProjectDetails IdInfo;

    public Developer DeepCopy()
    {
        Developer clone = (Developer)this.MemberwiseClone();

        clone.IdInfo = new ProjectDetails(IdInfo.IdNumber);
        clone.Name = Name;

        return clone;
    }
}
