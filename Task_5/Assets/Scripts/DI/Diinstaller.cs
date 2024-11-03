using Common;
using Control;
using UnityEngine;
using Zenject;

namespace DI
{
    public class Diinstaller : MonoInstaller
    {
        [SerializeField] private Claw claw;
        [SerializeField] private Model model;
        [SerializeField] private InputDetector inputDetector;

        public override void InstallBindings()
        {
            BindClaw();
            BindModel();
            BindInputDetector();
        }

        private void BindClaw()
        {
            var clawOnScene = Container.InstantiatePrefabForComponent<Claw>(claw);

            Container.Bind<Claw>().FromInstance(clawOnScene).AsSingle();
        }

        private void BindModel()
        {
            var modelOnScene = Container.InstantiatePrefabForComponent<Model>(model);

            Container.Bind<Model>().FromInstance(modelOnScene).AsSingle();
        }

        private void BindInputDetector()
        {
            var inputDetectorOnScene = Container.InstantiatePrefabForComponent<InputDetector>(inputDetector);

            Container.Bind<InputDetector>().FromInstance(inputDetectorOnScene).AsSingle();
        }
    }

}