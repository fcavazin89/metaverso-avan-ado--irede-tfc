🌳 ParkMeta — Meu Primeiro Ambiente VR
Aluno: Tiago Ferreira Cavazin
Curso: Web 3.0 | Residência em TIC 29
Professor(a): Ana Beatriz
Data: 05/05/2026

📌 Apresentando o Projeto
O ParkMeta é um ambiente virtual externo desenvolvido em Unity com suporte ao Meta XR SDK. O projeto simula um parque público navegável no contexto do Metaverso, onde o usuário pode explorar o espaço em primeira pessoa, interagir com objetos da cena e vivenciar uma experiência imersiva tanto no Unity Editor (PC) quanto no headset Meta Quest.
A cena é composta por chão navegável, skybox configurado, mais de 5 objetos 3D posicionados de forma coerente e ao menos uma interação funcional implementada em C#.

🎯 Contexto e Objetivos
O ambiente representa um parque público virtual inserido no Metaverso, com foco em lazer, exploração e aprendizado de navegação XR.
O objetivo principal é demonstrar como espaços cotidianos podem ser digitalmente recriados para proporcionar experiências imersivas acessíveis — seja via headset Meta Quest ou diretamente no computador. No contexto educacional, o projeto conecta teoria e prática dos fundamentos de desenvolvimento XR com Unity.
Problema resolvido: proporcionar um ambiente de exploração VR navegável e interativo sem exigir hardware especializado para os primeiros testes, utilizando o Unity Editor no PC como ambiente de validação.

🗺️ Ambiente Virtual — O que tem na cena?
ObjetoTipoFunçãoGround_ParkPlane (10x10)Chão navegável do parqueTree_1 / 2 / 3Cylinder + SphereÁrvores com tronco e copaBench_ParkCube compostoBanco interativo do parqueLampPost_01Cylinder + PointLightPoste com iluminação pontualRock_1 / 2 / 3Sphere achatadaPedras decorativasSun_DirectionalLightDirectionalLightLuz solar estilo fim de tardeSkyboxMaterialAmbiente externo ao redor

⚙️ Configuração Técnica

Unity: 2022.3 LTS (ou superior)
Meta XR SDK: instalado via Package Manager (All-in-One SDK)
XR Plugin Management: OpenXR ativado nas abas PC e Android
Build Settings: plataforma Android (Meta Quest 2/3)
Texture Compression: ASTC
Minimum API Level: Android 10 (API 29)
Scripting Backend: IL2CPP | Architecture: ARM64


🎮 Controles (Teste no PC)
TeclaAçãoW / A / S / DMovimentaçãoMouseRotação da câmeraLeft ShiftCorrerEspaçoPularEInteragir com objetoGSoltar objeto seguradoEscapePausar / liberar cursor

O projeto foi testado e validado no Unity Editor antes do build Android.


🤝 Interação Funcional
O projeto implementa uma interação de mudança de cor + feedback sonoro ao pressionar [E] sobre objetos marcados com a tag Interactable.
Como funciona:

ObjectInteraction.cs lança um Raycast a partir do centro da câmera
Ao detectar objeto com tag Interactable, destaca-o em amarelo e exibe a dica [E] Interagir
O jogador pressiona [E] → InteracaoSimples.cs recebe o evento via interface IInteractable
O objeto muda de cor (para ciano), aumenta levemente de escala e toca um AudioClip
Pressionar [E] novamente restaura o estado original (comportamento de toggle)


📁 Estrutura do Repositório
metaverso---irede-tfc/
├── Assets/
│   ├── Scenes/          ← MainScene.unity
│   ├── Scripts/         ← PlayerMovement.cs
│   │                       SceneSetup.cs
│   │                       XRConfiguration.cs
│   │                       ObjectInteraction.cs
│   │                       InteracaoSimples.cs
│   │                       UIManager.cs
│   └── Materials/       ← materiais da cena
├── ProjectSettings/     ← configurações de Build e XR
├── Packages/            ← manifest.json
├── README.md            ← este arquivo
└── .gitignore           ← ignora /Library e /Temp

🧱 Hierarquia de GameObjects
MainScene
├── [ MANAGEMENT ]
│   └── SceneManager
│       ├── SceneSetup.cs
│       └── XRConfiguration.cs
│
├── [ PLAYER ]
│   └── Player
│       ├── CharacterController
│       ├── PlayerMovement.cs
│       ├── ObjectInteraction.cs
│       └── Main Camera
│           └── HoldPoint
│
├── [ UI ]
│   └── Canvas
│       ├── HUDPanel
│       │   ├── CrosshairImage
│       │   └── HintText
│       └── PausePanel
│           ├── ResumeButton
│           └── QuitButton
│
├── [ ENVIRONMENT ]
│   ├── Ground_Park
│   └── Sun_DirectionalLight
│
└── [ PROPS ]
    ├── Trees/
    │   ├── Tree_1
    │   ├── Tree_2
    │   └── Tree_3
    ├── Furniture/
    │   └── Bench_Park   [Tag: Interactable]
    ├── Lights/
    │   └── LampPost_01
    └── Rocks/
        ├── Rock_1       [Tag: Interactable]
        ├── Rock_2
        └── Rock_3

🛠️ Processo de Criação e Dificuldades
Como desenvolvi o projeto
O desenvolvimento seguiu uma abordagem incremental: primeiro configurei o ambiente técnico (Unity + Meta SDK + XR Plugin), depois construí a cena com primitivos Unity organizados em hierarquia lógica, e por fim implementei os scripts de movimentação, interação e UI.
Cada script foi desenvolvido de forma independente e comentado para facilitar a compreensão e manutenção. A geração automática dos objetos via SceneSetup.cs agilizou muito o processo e garantiu nomenclatura consistente desde o início.
Principais desafios

Configuração do XR Plugin Management: entender a diferença entre as abas PC e Android e quais features habilitar no OpenXR foi o passo mais confuso do início
CharacterController vs Rigidbody: optar pelo CharacterController foi a decisão certa para movimentação em VR sem problemas de física inesperados
Cursor preso na tela: resolvido com Cursor.lockState = CursorLockMode.Locked no Start e toggle via Escape
Integração entre scripts: o uso da interface IInteractable desacoplou a lógica de detecção da lógica de interação, tornando o sistema extensível para novos objetos

Como resolvi
Testei frequentemente no Unity Editor antes de qualquer build, documentei as configurações de Build Settings e consultei a documentação oficial do Meta XR SDK para resolver incompatibilidades de versão.

🚀 Melhorias Futuras

 Suporte a controles físicos do Meta Quest (Trigger + Grip) via XR Interaction Toolkit
 Narração de áudio ao se aproximar de objetos (painel de informação por proximidade)
 Modelos 3D da Asset Store substituindo os primitivos
 Sistema de dia/noite com variação de skybox
 Multiplayer com Photon (PUN2) para interação entre usuários


🔗 Links

Repositório: github.com/fcavazin89metaverso-avan-ado--irede-tfc


© 2026 — Tiago Ferreira Cavazin | Web 3.0 — Residência em TIC 29 | Projeto acadêmico de uso educacional.
