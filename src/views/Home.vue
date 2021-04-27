<template>
  <v-main class="home">
    <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
    <!-- <HelloWorld msg="Welcome to Your Vue.js App"/> -->
    <v-row>
      {{welcome}}
    </v-row>
    <v-row class="row-con" style="display:flex; justify-content:space-between">
      <v-col class="flex-grow-1  flex-shrink-0 mr-10">
          <div id="intro" style="width:20em"> {{intro}} </div>
      </v-col>
      <v-col class="flex-grow-1">
        <Carousel class="car"/>
      </v-col>
    </v-row>
    <RecentNews/>

  </v-main>
</template>
<style lang="css" scoped>
.home, .row-con {
  width: 100%;
}
.row-con {
  flex-wrap: nowrap;
}
.row-con v-col {
  width: 40%;
}
</style>
<script>

// @ is an alias to /src
import Carousel from '@/components/Carousel.vue'
import RecentNews from '@/components/RecentNews.vue'

export default {
  // name: 'Home',
  components: {
    Carousel,
    RecentNews
  },
  data: () => ({
    welcome: 'Welcome To GPXG！！！',
    intro: '实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍 实验室简单介绍',
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
