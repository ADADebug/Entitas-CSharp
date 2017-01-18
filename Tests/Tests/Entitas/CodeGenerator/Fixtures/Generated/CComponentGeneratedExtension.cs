//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public sealed partial class TestEntity : Entity {

        static readonly CComponent cComponent = new CComponent();

        public bool isC {
            get { return HasComponent(ContextAComponentIds.C); }
            set {
                if(value != isC) {
                    if(value) {
                        AddComponent(ContextAComponentIds.C, cComponent);
                    } else {
                        RemoveComponent(ContextAComponentIds.C);
                    }
                }
            }
        }
    }
}

    public partial class ContextAMatcher {

        static IMatcher<TestEntity> _matcherC;

        public static IMatcher<TestEntity> C {
            get {
                if(_matcherC == null) {
                    var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(ContextAComponentIds.C);
                    matcher.componentNames = ContextAComponentIds.componentNames;
                    _matcherC = matcher;
                }

                return _matcherC;
            }
        }
    }

    public partial class ContextBMatcher {

        static IMatcher<TestEntity> _matcherC;

        public static IMatcher<TestEntity> C {
            get {
                if(_matcherC == null) {
                    var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(ContextBComponentIds.C);
                    matcher.componentNames = ContextBComponentIds.componentNames;
                    _matcherC = matcher;
                }

                return _matcherC;
            }
        }
    }

    public partial class ContextCMatcher {

        static IMatcher<TestEntity> _matcherC;

        public static IMatcher<TestEntity> C {
            get {
                if(_matcherC == null) {
                    var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(ContextCComponentIds.C);
                    matcher.componentNames = ContextCComponentIds.componentNames;
                    _matcherC = matcher;
                }

                return _matcherC;
            }
        }
    }
