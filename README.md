# EcoMeta: Galeria de Consciência Digital
**Aluno:** [Tiago Ferreira Cavazin]  
**Turma:** Residência em TIC 29  
**Data:** [05/05/2026]  

## 🎯 Sobre o Projeto
Ambiente educacional imersivo em Realidade Virtual que ensina princípios de sustentabilidade digital e economia de recursos em Web3. O usuário explora estações interativas que demonstram o impacto de escolhas tecnológicas no meio ambiente virtual e real.

## 🎮 Como Jogar (Teste no PC)
- **W/A/S/D ou Setas:** Movimentação
- **Mouse:** Rotacionar câmera
- **Clique Esquerdo:** Interagir com objetos destacados
- **Esc:** Liberar cursor

## ⚙️ Configuração Técnica
- Unity 2022.3.15f1 LTS
- Meta XR All-in-One SDK (via Package Manager)
- XR Plugin Management: OpenXR ativado para Android
- Build Settings: Android, API Level 29+, ASTC compression, ARM64

## 🧩 Interação Implementada
Objeto `QUAD_PainelEducativo` com script `InteracaoPainel.cs`:
1. Hover: objeto destaca em amarelo
2. Select (clique/trigger): muda para verde, toca som, exibe log no console
3. Feedback visual e sonoro para reforço educativo

## 📦 Estrutura do Projeto
