using System.Configuration;
using MbUnit.Framework;
using SolrNet;
using SolrNet.Impl;
using StructureMap.Configuration.DSL;
using StructureMap.SolrNetIntegration.Config;

namespace StructureMap.SolrNetIntegration.Tests
{
    [TestFixture]
    public class MultiCoreTests
    {
        [SetUp]
        public void SetUp()
        {
            var solrConfig = (SolrConfigurationSection)ConfigurationManager.GetSection("solr");
            ObjectFactory.Initialize(c =>
            {
                c.Scan(s =>
                {
                    s.Assembly(typeof(SolrNetRegistry).Assembly);
                    s.Assembly(typeof(SolrConnection).Assembly);
                    s.WithDefaultConventions();
                });
                c.AddRegistry(new SolrNetRegistry(solrConfig.SolrServers));
            });
        }

        [Test]
        public void Get_SolrOperations_for_Entity()
        {
            var solrOperations = ObjectFactory.Container.GetInstance<ISolrOperations<Entity>>();
            Assert.IsNotNull(solrOperations);
        }

        [Test]
        public void Get_SolrOperations_for_Entity2()
        {
            var solrOperations2 = ObjectFactory.Container.GetInstance<ISolrOperations<Entity2>>();
            Assert.IsNotNull(solrOperations2);
        }
    }
}