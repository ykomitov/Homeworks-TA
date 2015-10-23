namespace EfCodeFirst.SampleDataGenerator
{
    using System;
    using System.Linq;

    public abstract class DataGenerator : IDataGenerator
    {
        private IRandomDataGenerator random;
        private StudentSystemCFEntities db;
        private int count;

        public DataGenerator(IRandomDataGenerator randomGenerator, StudentSystemCFEntities database, int numberToGenerate)
        {
            this.random = randomGenerator;
            this.db = database;
            this.count = numberToGenerate;
        }

        protected IRandomDataGenerator Random
        {
            get { return this.random; }
        }

        protected StudentSystemCFEntities Db
        {
            get { return this.db; }
        }

        protected int Count
        {
            get { return this.count; }
        }

        public abstract void Generate();
    }
}
