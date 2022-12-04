namespace LinkedListWithExtraSteps
{
    class Node
    {
        public double data;
        public Node next;
    }
    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void başaEkle(double data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = head;
            head = newNode;
        }
        public void ortayaEkle(double data)
        {
            Node newNode = new Node();
            newNode.data = data;
            Node temp = head;
            int sayac = 0;
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                    sayac++;
                }
                Node current = head;
                for (int i = 0; i < sayac / 2; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }

        }
        public void sonaEkle(double data)
        {
            Node newNode = new Node();
            newNode.data = data;
            Node temp = head;
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        public void display()
        {
            Node temp = head;
            if (temp != null)
            {
                Console.WriteLine("Listedeki elemanlar:");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            else
                Console.WriteLine("Liste boş");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            string cevap = "e";
            while (cevap == "E" || cevap == "e")
            {
                Console.WriteLine("Eklemek istediğiniz sayıyı giriniz:");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz yeri giriniz(baş:1 orta:2 son:3):");
                int yer = Convert.ToInt32(Console.ReadLine());
                if (yer == 1)
                {
                    linkedList.başaEkle(number);
                }
                else
                    if (yer == 2)
                {
                    linkedList.ortayaEkle(number);
                }
                else
                    linkedList.sonaEkle(number);
                Console.WriteLine("Eklemeye devam edecek misiniz?(E/e/H/h)");
                cevap = Console.ReadLine();
            }
            linkedList.display();
            Console.ReadKey();
        }
    }
}