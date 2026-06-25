# The Adventures of Abasat

![Unity Version](https://img.shields.io/badge/Unity-2022.3.32f1-blue?logo=unity)
![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Mac%20%7C%20Linux-lightgrey)
![Genre](https://img.shields.io/badge/Genre-2D%20Platformer-orange)

**The Adventures of Abasat** é um jogo de plataforma 2D desenvolvido na engine **Unity**. O projeto foi concebido e desenvolvido em **2024** como parte dos requisitos práticos da disciplina de **Engenharia de Sistemas A** da **UERJ (Universidade do Estado do Rio de Janeiro)**.

O protagonista e temática do jogo são inteiramente baseados no **Abasat**, o mascote oficial da **UERJ Sats**, a equipe de desenvolvimento e pesquisa de satélites e engenharia aeroespacial da universidade.

---

## 🌌 História e Objetivo do Jogo

Na pele do carismático abacate astronauta Abasat, o jogador é lançado em uma importante missão no espaço sideral. O objetivo principal é navegar por plataformas flutuantes e perigosas para **resgatar os CubeSats** perdidos na órbita cósmica. Após coletar todos os satélites espalhados pelo nível, o jogador deve alcançar e capturar a **medalha final** para consagrar o sucesso da missão e finalizar a jornada.

---

## 🚀 Estrutura e Telas do Jogo

O jogo foi projetado focado em um ciclo completo de interação (Game Loop), dividido estritamente em 3 telas principais:

1. **Tela Inicial (`StartScene`):** Apresenta o menu principal com o título do jogo, a arte do Abasat com óculos escuros e botões interativos para iniciar a missão (`Start`) ou fechar a aplicação (`Quit`).
2. **Tela de Game Over:** Ativada caso o Abasat falhe em sua jornada ou caia no espaço profundo. Oferece a escolha para reiniciar a partida de forma rápida (`Restart Game`) ou retornar de vez para a tela inicial (`Return`).
3. **Tela de Vitória (`Abasat Wins`):** Exibe a celebração do sucesso da missão ao resgatar com êxito os CubeSats e capturar a moeda/medalha final, apresentando o Abasat segurando o troféu de ouro e permitindo reiniciar o jogo ou voltar ao menu inicial.

---

## 🛠️ Tecnologias e Implementação Técnica

- **Engine:** Unity 2022.3.32f1 (Editor em ambiente Windows/DX11).
- **Mecânicas 2D:** Utilização do sistema de *Tilemaps* para a estruturação do cenário espacial, física por componentes (`Rigidbody2D`) e detecção de colisões via triggers (`CircleCollider2D`) para o resgate dos CubeSats e medalhas.
- **Arquitetura de Projeto:** Organização modular do diretório de *Assets* para boas práticas de desenvolvimento:
  - `Animation/` - Controladores e clipes de animação do personagem.
  - `GameObjects/` - Elementos visuais e sprites da interface e do cenário de estrelas.
  - `Prefabs/` - Objetos reaproveitáveis instanciados na cena (como o prefab `Coin` usado na lógica dos satélites coletáveis).
  - `Scenes/` - Arquivos de cena das três telas estruturadas no jogo.
  - `Scripts/` - Lógica lógica programada em C# para controle de movimentação, contagem de itens, gerenciamento de estados de UI e transição de cenas.

---

## 🎮 Como Executar o Projeto

1. Clone este repositório em seu ambiente local:
   ```bash
   git clone [https://github.com/seu-usuario/the-adventures-of-asat.git](https://github.com/seu-usuario/the-adventures-of-asat.git)
