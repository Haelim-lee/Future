using System.Data;

namespace future
{
    public  class DBType
    {
        public SqlDbType DataType { get; set; }
        public int DataSize { get; set; }
        public object DataValue { get; set; }
        public DBType(object dataValue, SqlDbType dataType, int dataSize)
        {
            this.DataType = dataType;
            this.DataSize = dataSize;
            this.DataValue = dataValue;
        }


    }
}