# Git Flow e Padrões de Commits - Projeto EstimaDev

## Git Flow

O Git Flow é uma estratégia de desenvolvimento que define regras e práticas para organizar o fluxo de trabalho em um projeto Git. O objetivo é fornecer um método estruturado para gerenciar branches, releases e hotfixes, garantindo um desenvolvimento colaborativo e organizado.

### Branches Padrão

1. **main:** Esta é a branch principal do repositório. Ela sempre deve refletir a versão mais estável e de produção do projeto.

2. **develop:** Esta branch é usada para desenvolvimento contínuo. Novas funcionalidades e melhorias são mescladas nesta branch à medida que são concluídas e revisadas.

3. **feature/{nome-da-feature}:** Para o desenvolvimento de novas funcionalidades, cada desenvolvedor deve criar uma branch de feature a partir da branch `develop`. Exemplo: `feature/nova-funcionalidade`.

4. **release/{versao}:** Quando uma versão estável está pronta para ser implantada, uma branch de release é criada a partir da branch `develop`. Exemplo: `release/1.0.0`. Nesta branch, apenas correções de bugs menores e ajustes finais são permitidos.

5. **hotfix/{nome-do-hotfix}:** Para correção de bugs críticos em produção, uma branch de hotfix é criada a partir da branch `main`. Exemplo: `hotfix/correcao-crucial`.

6. **bugfix/{nome-do-bug}:** Para correção de bugs menos críticos em produção ou desenvolvimento, uma branch de bugfix é criada a partir da branch `main`. Exemplo: `bugfix/correcao-de-validacao`.

### Regras para Merge

- As branches de feature só podem ser mescladas na branch `develop` após revisão por pares (code review).

- A branch de release só pode ser mesclada na branch `main` e na branch `develop` após revisão e aprovação.

- A branch de hotfix só pode ser mesclada na branch `main` e na branch `develop` após correção do bug e revisão.

- A branch de bugfix pode ser mesclada na branch `main` e na branch `develop` após correção do bug e revisão.

## Padrões de Commits

Para manter um histórico de commits organizado e informativo, usaremos mensagens de commit convencionais com base nas [Conventional Commits](https://www.conventionalcommits.org/).

### Estrutura da Mensagem de Commit

Uma mensagem de commit convencional segue a seguinte estrutura:

```
<tipo>(<escopo>): <descrição>

[Corpo do commit (opcional)]

[Notas de rodapé (opcional)]
```

- **Tipo:** Indica o propósito do commit (exemplos: feat, fix, docs, style, refactor, perf, test, chore).
- **Escopo:** Opcional, descreve a parte do projeto afetada pela alteração.
- **Descrição:** Uma breve descrição do que foi feito no commit.
- **Corpo do commit:** Detalhes adicionais sobre a alteração, quando necessário.
- **Notas de rodapé:** Informações adicionais, como referência a issues ou pull requests relacionados.

### Exemplos de Commits

- `feat(usuario): Adiciona autenticação de usuário`
- `fix(usuario): Corrige problema de autenticação (#123)`
- `bugfix(correcao): Resolve erro de validação de entrada`
- `docs(readme): Atualiza documentação de uso`
- `style(css): Formatação consistente do CSS`
- `refactor(api): Refatora lógica de autenticação`
- `test(api): Adiciona testes de unidade para a API`
- `chore(build): Atualiza dependências do projeto`

### Regras de Commits

- Use verbos no imperativo, como "Adiciona", "Corrige", "Atualiza" em vez de passado ("Adicionou", "Corrigiu", "Atualizou").
- Mantenha as mensagens de commit curtas e concisas, limitando a linha de descrição a aproximadamente 72 caracteres.
- Se a mensagem de commit resolver uma issue específica, adicione uma referência à issue no formato `(#numero-da-issue)`. Por exemplo, `(Fix #123)`.

### Semver (Semantic Versioning)

Para gerenciar a versão do projeto, seguimos as diretrizes do [Semantic Versioning (Semver)](https://semver.org/). O número da versão é composto por três partes: MAJOR.MINOR.PATCH.

- **MAJOR:** Aumenta quando fazemos alterações incompatíveis na API ou mudanças significativas que podem afetar o uso do software.

- **MINOR:** Aumenta quando adicionamos funcionalidades novas de forma compatível com versões anteriores.

- **PATCH:** Aumenta quando fazemos correções de bugs ou outras melhorias menores compatíveis com versões anteriores.

### Alterando a Posição da Versão

A posição da versão é alterada de acordo com os seguintes padrões:

- **MAJOR:** A posição da versão MAJOR é aumentada quando a branch `main` recebe um merge de uma branch de `release`.

- **MINOR:** A posição da versão MINOR é aumentada quando uma nova funcionalidade é mesclada na branch `develop` (branch de feature).

- **PATCH:** A posição da versão PATCH é aumentada quando uma correção de bug é mesclada na branch `develop` (branch de bugfix) ou na branch `main` (branch de hotfix).

## Pull Requests (PRs)

Ao criar um Pull Request (PR), siga as seguintes diretrizes:

1. **Título do PR:** Inclua um título conciso e descritivo para o PR. Use verbos no imperativo, como "Adiciona", "Corrige", "Atualiza".

2. **Descrição do PR:** Forneça uma descrição detalhada do que o PR faz, por que ele é necessário e como ele afeta o projeto.

3. **Referências:** Adicione referências às issues ou problemas relacionados a este PR. Use o formato `(Fixes #numero-da-issue)` para indicar que o PR resolve

 uma issue específica.

4. **Conteúdo do PR:** Certifique-se de que o PR contenha apenas as alterações relevantes para a funcionalidade ou correção que está sendo proposta. Evite incluir alterações não relacionadas.

5. **Revisão por Pares:** Solicite revisão por pares de outros desenvolvedores antes de mesclar o PR. Certifique-se de que o código seja revisado e aprovado antes da mesclagem.

6. **Testes:** Verifique se os testes relevantes foram executados e se eles passaram com sucesso.

7. **Label e Milestone:** Atribua labels apropriadas e um milestone ao PR, se aplicável.

### Notas de Versão

As notas de versão são geradas a partir dos PRs mesclados em cada release. Cada PR deve ter um título e uma descrição claros para que suas contribuições possam ser facilmente incluídas nas notas de versão.

## Semver nas Notas de Versão

As notas de versão seguem a convenção Semver para indicar o impacto das alterações em cada release:

- **BREAKING CHANGE:** Indica mudanças que exigem atualizações significativas por parte dos usuários.

- **Feature:** Destaca as novas funcionalidades adicionadas.

- **Fix:** Mostra as correções de bugs feitas.

- **Enhancement:** Refere-se a melhorias gerais que não são novas funcionalidades nem correções de bugs.

---

Esperamos que essas diretrizes ajudem a manter um fluxo de trabalho organizado e rastreável no projeto EstimaDev. Mantenha-se consistente com essas práticas para facilitar o desenvolvimento e o controle de versões.
