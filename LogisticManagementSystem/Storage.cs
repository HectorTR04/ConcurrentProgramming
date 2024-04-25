using System.Threading;

namespace LogisticManagementSystem
{
    /// <summary>
    /// Class representing the shared buffer in the management system. Includes methods to add products
    /// and also remove them. Synchronisation for the system occurs in the methods of this class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Storage<T>
    {
        private T[] buffer;
        private int producePosition; //position in the buffer where the producer produces a product
        private int consumePosition; //position in the buffer where the consumer consumes a product
        private int elementsInBuffer; //the amount of products currently in the buffer
        public int ElementsInBuffer { get { return elementsInBuffer; } }
        private const int bufferSize = 20; //the constant size of the buffer
        Semaphore occupiedSlots = new Semaphore(0, bufferSize);
        Semaphore emptySlots = new Semaphore(bufferSize, bufferSize);
        Mutex sharedMutex = new Mutex();
        public Storage()
        {
            producePosition = -1;
            consumePosition = -1;
            elementsInBuffer = 0;
            buffer = new T[bufferSize];
        }
        public void Produce(T product)
        {
            try
            {
                emptySlots.WaitOne();
                sharedMutex.WaitOne();
                producePosition = (producePosition + 1) % bufferSize;
                buffer[producePosition] = product;
                elementsInBuffer++;
            }
            finally
            {
                sharedMutex.ReleaseMutex();
                occupiedSlots.Release();
            }
        }
        public T Consume()
        {
            try
            {
                occupiedSlots.WaitOne();
                sharedMutex.WaitOne();
                consumePosition = (consumePosition + 1) % bufferSize;              
                elementsInBuffer--;
                return buffer[consumePosition];
            }
            finally
            {
                sharedMutex.ReleaseMutex();
                emptySlots.Release();
            }                   
        }    
    }
}
