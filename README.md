# yang-group


## 修改说明
首先安装nodejs以及vue & vue cli 
### Project setup
克隆dev分支的内容到本地
```
git clone git@github.com:yang-group/yang-group.github.io.git
```
安装必要依赖（可以切换镜像或者挂梯子）
```
npm install
```

### Compiles and hot-reloads for development
执行server命令开启本地测试服务
```
npm run serve
```

### Compiles and minifies for production
修改完成之后build生成dist文件
```
npm run build
```

### Lints and fixes files
自动代码规范化命令
```
npm run lint
```

### 发布
```
npm run build
cd dist
git init
git add -u
git commit -m 'update pages'
git push -f git@github.com:yang-group/yang-group.github.io master:gh-pages   

```

### Customize configuration
See [Configuration Reference](https://cli.vuejs.org/config/).
