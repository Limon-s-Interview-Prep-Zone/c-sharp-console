## Non-Generic Collections:

#### ArrayList

first create new Object.

- Add(object): to add new object
- Remove(object): to remove specific object
- RemoveAt(position): to remove specific position
- Insert(position,object): insert object at specific position.
- Count: To get total items.
- Capacity: To get total items.

#### HasTable

It is collection base on key-value pair.It organizes based on hash code of keys.keys can not be same and it can be any type.
Methods:

- Add(key,value): add object based on key value pair;
- ContainsKey(key): find specific key
- ContainsValue(Value):find specific value.
  **We can iterate hashtable base on ht.Keys or ht.Values**

#### Stack:

LIFO means Last In Fast Out.
Methos:

- Push(object): add items
- Pop():remove first item
- Count: total items
- Peek(): To get first elemt
- Contains(object): to filter specifix object
- Clear(): remove all elements.

#### Queue:

FIFO means First In First Out.
Methods:

- enqueue(object): Add item
- Dequeue(): remove first item
- Count: total items
- Peek(): To get first elemt
- Contains(object): to filter specifix object
- Clear(): remove all elements.

## Generic Collections:

#### List<T>

- Add(object)
- Insert(position,object)
- Contains(object)
- Exists(value): return boolean
- Find(expression): return 1st matching
- FindLast(expression): return last matches
- FindAll(expression): filter items based on specific condition
- FindIndex(expression): return first matching index
- FindLastIndex(expression): return last matchig index
- AddRange(IEnumerable<T>)
- InsertRange(position,IEnumerable<T>)
- GetRange(startPosition,endPosition)
- RemoveRange(startPosition,endPosition)
- Clear(): remove all items.
- Sort():
- Reverse():
- Remove(object)
- RemoveAt(position)

#### Dictionary

Methods:

- Add(key,object)
- item[value]: to find specific value
- ContainsKey(key)
- ContainsValue(value)
- Remove(key)
- Clear()
- TryGetValue(tkey,out object)
- ToDictionary(key=>key.Id,value=>value): use to convert array or list to Dictionary
- Convert Dictionary To List: new List<T>(dic.Values)
- Dictionary To Array: Type [] arr=new Type[dic.Count] then dic.Values.CopyTo(arr,index)

#### HasSet:

Can not have Duplicate data.
Methods:

- Add(object)
- Remove(pbject)
- RemoveWhere(expression)
- Count
- ToArray(): covert a HasSet To Array
