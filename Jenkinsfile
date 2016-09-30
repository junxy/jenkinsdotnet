node {
    stage 'Checkout'
        checkout scm

    stage 'Clean'
        bat "\"${tool name: 'Default', type: 'hudson.plugins.git.GitTool'}\" clean -ndx -e .sonarqube/ -e packages/"
        bat "\"${tool name: 'Default', type: 'hudson.plugins.git.GitTool'}\" clean -fdx -e .sonarqube/ -e packages/"

    stage 'Nuget'
//        bat "\"${tool 'NuGet 3.3.0'}/nuget\" restore -MSBuildVersion 14 HjRedisClientWrap.sln"
        bat "\"${tool name: '.Net Core 1.0.1', type: 'com.cloudbees.jenkins.plugins.customtools.CustomTool'}\\dotnet\" restore"

    stage 'Build'
        bat "\"${tool name: '.Net Core 1.0.1', type: 'com.cloudbees.jenkins.plugins.customtools.CustomTool'}\\dotnet\" build JenkinsDotNet/"
        bat "\"${tool name: '.Net Core 1.0.1', type: 'com.cloudbees.jenkins.plugins.customtools.CustomTool'}\\dotnet\" test JenkinsDotNet.Tests/"
//        bat "\"${tool 'v14'}\" HjRedisClientWrap.sln /p:Configuration=Debug /m /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

//    stage 'Archive'
//        archive 'Hj.RedisClient.Wrap/bin/Debug/**'

}