<template>
  <v-main class="home">
    <v-row>
          <Carousel id="carousel" class="car" :imgItem="items" :papers="papers"/>
    </v-row>
    <v-row class="welcomeText">
        <h1>
          {{welcome}}
        </h1>
        <div class="line"></div>
        <div class="welcomeContent">
          {{intro}}
        </div>
    </v-row>
    <v-row style="margin-top:0">
      <v-col class="recentNews">
        <RecentNews :recentNews="recentNews" />
      </v-col>
    </v-row>
    <v-row style="margin-top:0">
      <v-col class="contactUs">
        <div class="contactUsLeft">
          <h1 class="contactUsTitle">CONTACT US</h1>
          <div class="contactUsLeftContent">
            <div class="contactUsLeftContentChild">
                <h2>Mailing Address</h2>
                <span>
                  School of Artificial Intelligence, Jilin University<br>
                  吉林省长春市前进大街2699号<br>
                  sai@jlu.edu.cn
                </span>
            </div>
            <div class="contactUsLeftContentChild">
                <h2>General Inquiries</h2>
                <span>
                  Admin: Xi Yang<br>
                  E-mail: yangxi21@jlu.edu.cn
                </span>
            </div>
          </div>
        </div>
        <div class="contactUsRight">
          <h1 class="contactUsTitle">LOCATION</h1>
          <div class="positionImgBox mt-5">
            <v-img src="img/position.png" width="280" height="180" id="positionImg"></v-img>
          </div>
        </div>
      </v-col>
    </v-row>
  </v-main>
</template>
<style lang="css" scoped>
.briefText p {
  text-indent: 2em;
}
#carousel {
  width: 1440px;
  margin: 50px auto;
}
.recentNews{
  background-color: white;
  margin: 50px auto;
}
.welcomeText{
  height: 500px;
  width: 100%;
  margin: 30px auto;
  display: flex;
  flex-direction:column;
  align-content:flex-start;
  background-color: #F2F4FA;
  margin-top: 20px;
  margin-bottom: 0;
}
.welcomeText:hover .line{
  width: 180px;
  transition:width 1s;
}
.welcomeText h1{
  margin: 0 auto;
  width: 100%;
  font-size: 40px;
  color: #323232;
  text-align: center;
  margin-top: 150px;
}
.welcomeText .line{
  height: 6px;
  width: 100px;
  background-color: #4582B4;
  margin: 0 auto;
  border-radius: 5px;
}
.welcomeContent{
  margin: 0 auto;
  width: 50%;
  margin-top: 30px;
  color: #757575;
}
.contactUs{
  height: 500px;
  width: 100%;
  margin: 30px auto;
  display: flex;
  justify-content: space-around;
  background-color: #F2F4FA;
  margin-top: 20px;
  margin-bottom: 0;
}
.contactUsLeftContent{
  display: flex;
  justify-content: space-between;
}
.contactUsLeft{
  min-width: 20%;
  max-width: 50%;
  padding-left: 180px;
}
.contactUsRight{
  min-width: 30%;
  padding-left: 50px;
}
.contactUsTitle{
  font-size: 30px;
  font-weight: 900;
  color: #4582B4;
  padding-top: 120px;
}
.contactUsLeftContentChild{
  max-width: 40%;
  padding-top: 30px;
}
.contactUsLeftContent h2{
  font-weight: 900;
  font-size: 20px;
  color: #545454;
}
.contactUsLeftContent span{
  color: #545454;
  font-size: 18px;
  font-weight: 400;
}
.positionImgBox{
  width: 280px;
  height: 180px;
  overflow: hidden;
}
#positionImg:hover{
  transform: scale(1.5);
  transition: 2s;
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
    items: jsondata.imgItems,
    recentNews: jsondata.recentNews,
    papers: jsondata.paperList,
    welcome: jsondata.welcome,
    intro: jsondata.intro,
    admission: jsondata.admission
  })
}
</script>
