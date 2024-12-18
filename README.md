# minimal-api-docker-container
Distribuindo e consumindo uma Minimal API por meio de contêineres Docker usando o comando <code>dotnet publish</code>

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)

## Sobre o projeto
Este projeto mostra como distribuir e consumir uma Minimal API por meio de contêineres Docker usando o comando <code>dotnet publish</code>.

Os contêineres têm muitos recursos e benefícios, como o de serem uma infraestrutura imutável, fornecer uma arquitetura portátil e permitir a escalabilidade. A imagem pode ser usada para criar contêineres para seu ambiente de desenvolvimento local, nuvem privada ou nuvem pública.

Usamos o comando abaixo para preparar a aplicação Minimal API para distribuição criando a imagem no Docker:
```
dotnet publish -p:PublishProfile=DefaultContainer
```

<div align="center">
    <img src="https://github.com/user-attachments/assets/e3e7398d-c73c-4540-8bc2-205a6393be33"</img>
    <img src="https://github.com/user-attachments/assets/fc94587c-504b-4578-aa1d-0541f77e50dd"</img>
</div>

Usamos o comando abaixo para executar o contêiner Docker criado a partir da imagem minimal-api-docker-container, mapeando a porta 8000 do host para a porta 8080 do contêiner,
executando a aplicação Minimal API dentro do contêiner, permitindo que a aplicação seja acessada via <code>http://localhost:8000</code>:
```
docker run --name minimal-api-docker-container -p 8000:8080  minimal-api-docker-container
```

<div align="center">
    <img src="https://github.com/user-attachments/assets/aef60567-7239-427a-903e-b3ce326e4090"</img>
    <img src="https://github.com/user-attachments/assets/76c04a14-1ecb-44bd-9f3a-b62751d5b024"</img>
    <img src="https://github.com/user-attachments/assets/aa8503c9-e40a-4271-9368-11724fe6df71"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/core/docker/publish-as-container/

https://www.docker.com/

## Licença
GPL-3.0 license
