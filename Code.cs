public class Code {
    
    private string m_Name
    private bool m_IsRunning;
    
    public Code(string name){
        m_Name = name;
        m_IsRunning = false;
    }
    
    public void RunCode(){
        m_IsRunning = true;
        Console.WriteLine("Running C# code!");
    }
}
