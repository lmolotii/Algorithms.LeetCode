namespace LeetCode.Exercises.Queues
{
    public class MyCircularQueue
    {
        private readonly  int[] _queue;
        private int _firstIndex;
        private int _lastIndex;
        private int _numberOfElements; 
        
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            _queue = new int[k];
            _firstIndex = -1;
            _lastIndex = -1;
            _numberOfElements = 0;
        }
    
        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {   
            if (_numberOfElements == _queue.Length)
                return false;
            
            if (_lastIndex + 1 == _queue.Length)
                _lastIndex = 0;
            else
                _lastIndex++;

            _queue[_lastIndex] = value;
            _numberOfElements++;
            
            if (_numberOfElements == 1)
                _firstIndex = _lastIndex;
            
            return true;
        }
    
        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (_numberOfElements == 0)
                return false;

            _queue[_firstIndex] = 0;
            
            if (_firstIndex + 1 == _queue.Length)
                _firstIndex = 0;
            else
                _firstIndex++;

            _numberOfElements--;
            
            return true;
        }
    
        /** Get the front item from the queue. */
        public int Front()
        {
            if (_numberOfElements > 0)
                return _queue[_firstIndex];

            return -1;
        }
    
        /** Get the last item from the queue. */
        public int Rear()
        {
            if (_numberOfElements > 0)
                return _queue[_lastIndex];
            
            return -1;
        }
    
        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return _numberOfElements == 0;
        }
    
        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return _numberOfElements == _queue.Length;
        }
    }

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
}