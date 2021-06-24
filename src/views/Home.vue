<template>
  <v-main class="home">
    <v-row class="row-con" style="display:flex; justify-content:space-between">
        <h1>
          {{welcome}}
        </h1>
    </v-row>
    <v-row>
          <Carousel id="carousel" class="car" :imgItem="items" />
    </v-row>
    <v-row class="briefText">
      <p id="intro" > {{intro}} </p>
      <p id="admission"> {{admission}} </p>
    </v-row>
    <v-row>
      <v-col>
        <RecentNews :recentNews="recentNews" />
      </v-col>
    </v-row>

  </v-main>
</template>
<style lang="css" scoped>
.briefText p {
  text-indent: 2em;
}
#carousel {
  width: 80%;
  margin: 0 auto;
}
</style>
<script>
import YAML from 'yamljs'
// @ is an alias to /src
import Carousel from '@/components/Carousel.vue'
import RecentNews from '@/components/RecentNews.vue'
var nativeObject = YAML.load('./data/data.yml')
var jsonstr = JSON.stringify(nativeObject)
var jsondata = JSON.parse(jsonstr)
// Contact
export default {
  // name: 'Home',
  components: {
    Carousel,
    RecentNews
  },
  data: () => ({
    welcome: jsondata.welcome,
    intro: jsondata.intro,
    admission: jsondata.admission,
    items: jsondata.imgItems,
    recentNews: jsondata.recentNews
  })
}
</script>
