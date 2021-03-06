﻿
using LCL;
using LCL.ComponentModel;
using LCL.MetaModel;
using System.Diagnostics;

namespace LCL.Repositories.MongoDB
{
    public class BundleActivator : LCLPlugin
    {
        public override void Initialize(IApp app)
        {
            ServiceLocator.Instance.Register<IMongoDBRepositoryContext, MongoDBRepositoryContext>();
            ServiceLocator.Instance.RegisterType(typeof(IRepository<>), typeof(MongoDBRepository<>));
        }
    }
}
