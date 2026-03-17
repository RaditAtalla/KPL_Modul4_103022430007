MesinKopi.main();

public class MesinKopi
{
    enum State { OFF, STANDBY, BREWING, MAINTENANCE };
    
    public static void main()
    {
        State state = State.OFF;
        do
        {
            Console.WriteLine("Mesin kopi: " + state);
            Console.WriteLine("Operasi (power_on, power_off, start_brew, finish_brew, start_maintenance, finish_maintenance):");
            string operasi = Console.ReadLine();

            switch (state)
            {
                case State.OFF:
                    if(operasi == "power_on") { 
                        state = State.STANDBY;
                        Console.WriteLine("Mesin off berubah menjadi standby");
                    }
                    break;
                case State.STANDBY:
                    if(operasi == "start_brew")
                    {
                        state = State.BREWING;
                        Console.WriteLine("Mesin standby berubah menjadi brewing");
                    }
                    else if(operasi == "start_maintenance")
                    {
                        state = State.MAINTENANCE;
                        Console.WriteLine("Mesin standby berubah menjadi maintenance");
                    }
                    else if(operasi == "power_off")
                    {
                        state = State.OFF;
                        Console.WriteLine("Mesin standby berubah menjadi off");
                    }
                    break;
                case State.BREWING:
                    if(operasi == "finish_brew")
                    {
                        state = State.STANDBY;
                        Console.WriteLine("Mesin brewing berubah menjadi standby");
                    }
                    break;
                case State.MAINTENANCE:
                    if(operasi == "finish_maintenance")
                    {
                        state = State.STANDBY;
                        Console.WriteLine("Mesin maintenance berubah menjadi standby");
                    }
                    break;
                default:
                    Console.WriteLine("Perubahan state tidak valid");
                    break;
            }

        } while (true);
    }
}

//KodePaket k1 = new KodePaket();
//Console.WriteLine(k1.getKodePaket("Basic"));
//Console.WriteLine(k1.getKodePaket("Premium"));

//public class KodePaket
//{
//    enum Paket { Basic, Standard, Premium, Unlimited, Gaming, Streaming, Family, Student, Traveler}
//    public string getKodePaket(String namaPaket)
//    {
//        string[] kode = ["P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P2010",];
//        return kode[(int)Enum.Parse(typeof(Paket), namaPaket)];
//    }
//}