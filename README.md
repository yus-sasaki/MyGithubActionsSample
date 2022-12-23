# MyGithubActionsSample

本リポイトリは試作したGitHub Actionsを格納し、[workflows](https://github.com/yus-sasaki/MyGithubActionsSample/tree/main/.github/workflows)の公開が目的のリポジトリです。  
ソースコードは対象はC＃としており、buildなど一部のアクションは書き換えが必要となる場合があります。

## 

- [IssuesAssignAuthor.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/IssuesAssignAuthor.yml)
  - Issue作成時に自動的に自身をアサインします。（確認のためassign-author@v1をそのまま使っているだけです）

- [autoassigneesandreviewers.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/autoassigneesandreviewers.yml)
  - プルリクエストのReviewersとAssigneesを自動で設定させます。詳しい説明は[こちら](https://qiita.com/yusuke-sasaki/items/94a8f64e837966266bfb)を参照ください。

- [build.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/build.yml)
  - dotnetのコードに対するBuildとTestを行います。

- [createIssueBranch.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/createIssueBranch.yml)
  - [こちら](https://qiita.com/yusuke-sasaki/items/d2947a95aefdfd5d0264)の記事にて確認したアクションです。

- [publish-nuget.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/publish-nuget.yml)
  - dotnetのコードをnugetパッケージ化してNugetに公開します。

- [sonarcloud.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/sonarcloud.yml)
  - [SonarCloud](https://www.sonarsource.com/products/sonarcloud/)を利用した静的解析とGitHubを連携させるアクションです。詳しい説明は[こちら](https://qiita.com/yusuke-sasaki/items/4016eb74fde053d60559)を参照ください。

- [workflowtotalization.yml](https://github.com/yus-sasaki/MyGithubActionsSample/blob/main/.github/workflows/workflowtotalization.yml)
  - [こちら](https://qiita.com/yusuke-sasaki/items/60cc128233a1b602c9e8)の記事にて作成したGitHubActionsの稼働実績を出力するアクションです。
