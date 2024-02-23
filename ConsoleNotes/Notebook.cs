namespace ConsoleNotes;

internal class Notebook
{
    // Notebook myNotebook = new Notebook("My Notebook");

    #region Properties
    public Guid UID { get; private set; }
    public string Name { get; set; }    
    public DateTime Created { get; private set; }
    public DateTime LastModified { get; private set; }
    public string[] Tags { get; set; }
    public Note[] Notes { get; set; }
    #endregion

    #region Constructor
    public Notebook(string name)
    {
        UID = Guid.NewGuid();
        Name = name;
        Created = DateTime.Now;
        LastModified = DateTime.Now;
        Notes = new Note[0];
    }
    #endregion


}
