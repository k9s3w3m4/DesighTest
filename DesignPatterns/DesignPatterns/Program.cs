using System;

namespace DesignPatterns
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //调用具体工厂
            DongunAbstractFactor manDungun = new OnlyManDongun();
            manDungun.newNPC();
            manDungun.newRoom();

            DongunAbstractFactor womanDungun = new OnlyWomanBigDongun();
            womanDungun.newNPC();
            womanDungun.newRoom();

            

        }
    }

    /// <summary>
    /// 抽象产品1接口
    /// </summary>
    public interface DungunRoomFactor
    {


        void CreateRoom();


    }



    public class NormalRoom: DungunRoomFactor
    {
        public void CreateRoom()
        {
            Console.WriteLine("创建普通房间");
        }

      }

    public class BigRoom : DungunRoomFactor
    {
        public void CreateRoom()
        {
            Console.WriteLine("创建大房间");
        }
    }

    public class SmallRoom : DungunRoomFactor
    {
        public void CreateRoom()
        {
            Console.WriteLine("创建小房间");
        }
    }


    /// <summary>
    /// 抽象产品2：NPC 接口
    /// </summary>
    public interface NPCcreaterFactor
    {

        void CreateNPC();
    }


    public class ManNPC : NPCcreaterFactor
    {
        public void CreateNPC()
        {
            Console.WriteLine("创建男性NPC");
        }
    }

    public class WomanNPC : NPCcreaterFactor
    {
        public void CreateNPC()
        {
            Console.WriteLine("创建男性NPC");
        }
    }
    /// <summary>
    /// 抽象工厂，创建地下城接口
    /// </summary>
    public abstract class DongunAbstractFactor
    {
        public abstract DungunRoomFactor newRoom();

        public abstract NPCcreaterFactor newNPC();

    }

    /// <summary>
    /// 具体工厂:只有男性的普通房间
    /// </summary>
    public class OnlyManDongun : DongunAbstractFactor
    {


        public override NPCcreaterFactor newNPC()
        {
            Console.WriteLine("只有男性的地下城:创建男性");
            return new ManNPC();
        }



        public override DungunRoomFactor newRoom()
        {
            Console.WriteLine("只有男性的地下城:创建普通房间");
            return new NormalRoom();
        }
    }


    public class OnlyWomanBigDongun : DongunAbstractFactor
    {


        public override NPCcreaterFactor newNPC()
        {
            Console.WriteLine("只有女性的地下城：创建女性");
            return new WomanNPC();
        }



        public override DungunRoomFactor newRoom()
        {
            Console.WriteLine("只有女性的地下城：创建大房间");
            return new BigRoom();
        }
    }
}
