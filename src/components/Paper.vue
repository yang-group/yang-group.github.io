<template>
  <div>
    <v-row class="mt-1">
      <v-col class="pa-0" cols="3">
        <v-img
          :src="paper.image"
          max-height="150"
          class="pa-0 mr-5"
          max-width="250"
          :aspect-ratio="1 / 1"
          style="margin: 0 auto"
        />
      </v-col>
      <v-col cols="9" class="pa-0">
        <div class="mb-2">
          <b>{{ paper.title }}</b>
        </div>
        <div class="mb-2">
          <i v-html="paper.authors"></i>
        </div>
        <div>
          <b v-html="paper.pub"></b>
          <span> {{ paper.year }} </span>
        </div>
        <div>
          <span v-show="paper.links.paper != null">
            <v-btn class="ma-1" color="green lighten-2" dark :href="paper.links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
          </span>
          <span v-show="paper.links.code != null">
            <v-btn class="ma-1" color="orange lighten-2" dark :href="paper.links.code">
              code
              <v-icon right>
                mdi-github
              </v-icon>
            </v-btn>
          </span>
          <span v-show="paper.links.data != null">
            <v-btn class="ma-1" color="light-blue lighten-2" dark :href="paper.links.data">
              data
              <v-icon right>
                mdi-database
              </v-icon>
            </v-btn>
          </span>
        </div>
      </v-col>
    </v-row>
  </div>
</template>
<script>
// { "title": "IntrA: 3D Intracranial Aneurysm Dataset for Deep Learning", "authors": "Xi Yang, Ding Xia, Taichi Kin, and Takeo Igarashi", "pub": "CVPR", "year": "2020", "ccf": "A", "image": "https://keepthinkingyx.github.io/Xi-Yang/pic/paperfinal.jpg", "links": { "code": "https://github.com/intra3d2019/IntrA", "paper": "https://arxiv.org/abs/2003.02920", "data": "https://drive.google.com/drive/folders/1yjLdofRRqyklgwFOC0K4r7ee1LPKstPh?usp=sharing" } }
export default {
  props: {
    paper: {
      type: Object
    }
  },
  data: () => ({})
}
</script>
