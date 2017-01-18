//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public sealed partial class TestEntity : Entity {

        static readonly CustomPrefixComponent customPrefixComponent = new CustomPrefixComponent();

        public bool myCustomPrefix {
            get { return HasComponent(ComponentIds.CustomPrefix); }
            set {
                if(value != myCustomPrefix) {
                    if(value) {
                        AddComponent(ComponentIds.CustomPrefix, customPrefixComponent);
                    } else {
                        RemoveComponent(ComponentIds.CustomPrefix);
                    }
                }
            }
        }
    }

    public sealed partial class TestContext : Context<TestEntity> {

        public TestEntity customPrefixEntity { get { return GetGroup(Matcher.CustomPrefix).GetSingleEntity(); } }

        public bool myCustomPrefix {
            get { return customPrefixEntity != null; }
            set {
                var entity = customPrefixEntity;
                if(value != (entity != null)) {
                    if(value) {
                        CreateEntity().myCustomPrefix = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }

    public partial class Matcher {

        static IMatcher<TestEntity> _matcherCustomPrefix;

        public static IMatcher<TestEntity> CustomPrefix {
            get {
                if(_matcherCustomPrefix == null) {
                    var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(ComponentIds.CustomPrefix);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCustomPrefix = matcher;
                }

                return _matcherCustomPrefix;
            }
        }
    }
}
