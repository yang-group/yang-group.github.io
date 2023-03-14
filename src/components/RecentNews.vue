<template>
  <v-card flat class="recentNewsCard">
    <v-card-title class="fontColor-498698 backgroundColor fontSize-30px mb-5">Recent News</v-card-title>
    <v-card-text class="backgroundColor">
      <v-list dense class="vList">
        <v-list-item-group color="">
          <v-container
            id="scroll-target"
            style="max-height: 300px"
            class="overflow-y-auto fontColor-498698 backgroundColor recentNewsCardContainer"
          >
            <v-list-item v-for="(info, i) in news" :key="i">
              <b class="fontColor-545454 fontSize-18px  mt-3 mb-3 ">【{{info.date}}】</b>  <div v-html="info.content" class="ml-3 mt-3 mb-3 fontColor-545454 fontSize-18px"></div>
            </v-list-item>
          </v-container>
        </v-list-item-group>
      </v-list>
    </v-card-text>
  </v-card>
</template>
<style lang="css" scoped>
.backgroundColor{
  background-color: white;
}
.recentNewsCard{
  width: 80%;
  margin: auto;
}
.vList{
  padding: 0px;
}
.recentNewsCardTitle{
  /* padding-bottom: 0; */
}
.recentNewsCardContainer{
  padding-top: 0;
}
.fontColor-498698{
  color: #4582B4;
}
.fontColor-545454{
  color: #545454;
}
.fontSize-18px{
  font-size: 18px;
}
.fontSize-30px{
  font-size: 30px;
}
</style>
<script>
export default {
  props: ['recentNews'],
  data: () => ({
    news: []
  }),
  mounted () {
    this.news = this.recentNews
  }
}
</script>
