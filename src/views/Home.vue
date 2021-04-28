<template>
  <v-main class="home">
    <v-row class="row-con" style="display:flex; justify-content:space-between">
      <v-col cols="6" class="briefText">
        <h1>
          {{welcome}}
        </h1>
          <p id="intro" > {{intro}} </p>
          <p id="admission"> {{admission}} </p>
      </v-col>
      <v-col cols="6">
          <Carousel class="car"/>
      </v-col>
    </v-row>
    <v-row>
      <v-col>
        <RecentNews/>
      </v-col>
    </v-row>

  </v-main>
</template>
<style lang="css" scoped>
.briefText p {
  text-indent: 2em;
}
</style>
<script>
import YAML from 'yamljs'
// @ is an alias to /src
import Carousel from '@/components/Carousel.vue'
import RecentNews from '@/components/RecentNews.vue'
var nativeObject = YAML.load('./data/data.yml')
var jsonstr = JSON.stringify(nativeObject)
// Contact

export default {
  // name: 'Home',
  components: {
    Carousel,
    RecentNews
  },
  data: () => ({
    welcome: 'Welcome To GPXG !!!',
    intro: '实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍',
    admission: '招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍 招生介绍',
    items: [
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg'
      },
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/sky.jpg'
      },
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/bird.jpg'
      },
      {
        src: 'https://cdn.vuetifyjs.com/images/carousel/planet.jpg'
      }
    ]
  })
}
</script>
