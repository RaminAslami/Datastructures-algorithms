namespace AlgorithmsDatastructures.HashTable;

public class HashTable
{
    public string[] _hashTable { get; set; }

    public HashTable()
    {
        _hashTable = new string[10];
    }

    private int _hash(string key)
    {
        return key.Length % _hashTable.Length;
    }
    
    public string Get(string key)
    {
        int hashkey = _hash(key);
        
        return _hashTable[hashkey];
    }

    public void Set(string key, string value)
    {
        int hashkey = _hash(key);
        
        //key is being hashed

        if (_hashTable[hashkey] != null)
        {
            Console.WriteLine("Collision detected!");
        }
        else
        {
            _hashTable[hashkey] = value;
        }
        
        
    }
}