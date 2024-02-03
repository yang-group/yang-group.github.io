<template>
  <v-carousel class="i-carousel" hide-delimiter-background show-arrows-on-hover height="400" :cycle="true
  ">
    <!-- :cycle="true" -->
    <!-- <v-carousel-item
      v-for="(item, i) in items"
      :key="i"
      :src="item.src"
    ></v-carousel-item> -->
    <!-- <v-carousel-item
      v-for="(item, i) in imgItem"
      :key="i"
      :src="item"
    >
      <v-sheet color="red" width="100%">

      </v-sheet>
    </v-carousel-item> -->
    <v-carousel-item>
      <v-sheet color="#4582B4" height="100%">
          <img :src="imgItem[11]" class="carousel-img" id="carousel-img1" style="margin-left: 15%">
          <img :src="imgItem[12]" class="carousel-img" id="carousel-img2" style="margin-left: 6%">
          <div class="carousel-text-odd">
            <h1 class="carousel-text-title font-color-strong" style="font-size:24px; padding-top:40px;">We released a mini-program called "Ji Jin Shi Bian"which was widely reported by Guangming Daily,Science and Techniology Daily and other media.</h1>
          </div>
      </v-sheet>
    </v-carousel-item>
    <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[13]" class="carousel-img" id="carousel-img2">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin" style="font-size: 26px;">SpaceEditing: Integrating Human Knowledge into Deep Neural Networks via Interactive Latent Space Editing</h1>
            <div class="carousel-text-content font-color-thin">
              Jiafu Wei, Ding Xia, Haoran Xie, Chia-Ming Chang, Chuntao Li, Xi Yang
            </div>
            <v-btn class="btn-even btn-ml  btn-mt" color="rgba(0,0,0,0)" width="130" height="40" :href="papers[0].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item>
    <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[14]" class="carousel-img" id="carousel-img2" style="margin-left: 16%;">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin" style="font-size: 26px;">PDFChatAnnotator: A Human-LLM Collaborative Multi-Modal Data Collection Tool for PDF-Format Catalogs</h1>
            <div class="carousel-text-content font-color-thin">
              Yi Tang, Chia-Ming Chang, Xi Yang
            </div>
            <v-btn class="btn-even btn-ml  btn-mt" color="rgba(0,0,0,0)" width="130" height="40" :href="papers[0].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item>
    <v-carousel-item>
      <v-sheet color="#4582B4" height="100%">
          <img :src="imgItem[10]" class="carousel-img" id="carousel-img3" style="margin-left: 5%">
          <div class="carousel-text-odd">
            <h1 class="carousel-text-title font-color-strong" style="font-size:30px; padding-top: 80px;">Successful Completion of IIGG Lab Team Building! </h1>
          </div>
      </v-sheet>
    </v-carousel-item>
    <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[9]" class="carousel-img" id="carousel-img4">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin" style="font-size:24px">Learning Joint Embedding of Point Clouds and Texts by Bidirectional Matching between Parts and Words</h1>
            <div class="carousel-text-content font-color-thin">Chuan Tang, Xi Yang, Bojian Wu, Zhizhong Han, Yi Chang</div>
            <v-btn class="ma-2 btn-even  btn-mt ml-16" color="rgba(0,0,0,0)" height="40" :href="papers[3].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
            <v-btn class="ma-2 btn-even btn-mt" color="rgba(0,0,0,0)"  height="40" :href="papers[3].links.code">
              code
              <v-icon right>
                mdi-github
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item>
    <v-carousel-item>
      <v-sheet color="#4582B4" height="100%">
          <img :src="imgItem[6]" class="carousel-img" id="carousel-img3" style="margin-left: 5%">
          <div class="carousel-text-odd">
            <h1 class="carousel-text-title font-color-strong" style="font-size:24px">Multi-Granularity Archaeological Dating of Chinese Bronze Dings Based on a Knowledge-Guided Relation Graph</h1>
            <div class="carousel-text-content font-color-strong-content">Rixin Zhou, Wei Jiafu, Qian Zhang, Qi Ruihua, Xi Yang, Chuntao Li</div>
            <v-btn class="ma-2 btn-even  btn-mt ml-16" color="#4582B4" height="40" :href="papers[2].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
            <v-btn class="ma-2 btn-even btn-mt" color="#4582B4"  height="40" :href="papers[2].links.code">
              code
              <v-icon right>
                mdi-github
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item>
    <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[8]" class="carousel-img" id="carousel-img4">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin" style="font-size:28px">SyncLabeling: A Synchronized Audio Segmentation Interface for Mobile Devices</h1>
            <div class="carousel-text-content font-color-thin">Yi Tang, Chia-Ming Chang, Xi Yang, Takeo Igarashi</div>
          </div>
      </v-sheet>
    </v-carousel-item>
    <!-- <v-carousel-item>
      <v-sheet color="#4582B4" height="100%">
          <img :src="imgItem[5]" class="carousel-img" id="carousel-img4" style="height:95%; margin-left: 15%; margin-top: 3%;">
          <div class="carousel-text-odd">
            <h1 class="carousel-text-title font-color-strong" style="font-size:28px">Four students received three-month internship support at the University of Tokyo. </h1>
          </div>
      </v-sheet>
    </v-carousel-item> -->
    <!-- <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[4]" class="carousel-img" id="carousel-img4">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin" style="font-size:28px">Efficient Human-in-the-loop System for Guiding DNNs Attention</h1>
            <div class="carousel-text-content font-color-thin">Yi He, Xi Yang, Chia-Ming Chang, Haoran Xie, Takeo Igarashi</div>
            <v-btn class="ma-2 btn-even  btn-mt-large ml-16" color="rgba(0,0,0,0)" height="40" :href="papers[3].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
            <v-btn class="ma-2 btn-even btn-mt-large" color="rgba(0,0,0,0)"  height="40" :href="papers[3].links.code">
              code
              <v-icon right>
                mdi-github
              </v-icon>
            </v-btn>
            <v-btn class="ma-2 btn-even btn-mt-large" color="rgba(0,0,0,0)" height="40" :href="papers[3].links.vedio">
            vedio
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item> -->
    <!-- <v-carousel-item>
      <v-sheet color="#4582B4" height="100%">
          <img :src="imgItem[0]" class="carousel-img" id="carousel-img1" ref="carousel-img1">
          <div class="carousel-text-odd">
            <h1 class="carousel-text-title font-color-strong">IntrA: 3D Intracranial Aneurysm Dataset for Deep Learning</h1>
            <div class="carousel-text-content font-color-strong-content">
              Xi Yang, Ding Xia, Taichi Kin, and Takeo Igarashi
            </div>
            <v-btn class="ma-1 btn-odd btn-mt-large ml-16" color="rgba(0,0,0,0)" :href="papers[5].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
            <v-btn class="ma-1 btn-odd btn-mt-large" color="rgba(0,0,0,0)" dark :href="papers[5].links.code">
              code
              <v-icon right>
                mdi-github
              </v-icon>
            </v-btn>
            <v-btn class="ma-1 btn-odd btn-mt-large" color="rgba(0,0,0,0)" dark :href="papers[5].links.data">
              data
              <v-icon right>
                mdi-database
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item> -->
    <!-- <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[1]" class="carousel-img" id="carousel-img2">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin">Part2Word: Learning Joint Embedding of Point Clouds and Text by Matching Parts to Words</h1>
            <div class="carousel-text-content font-color-thin">
              Chuan Tang, Xi Yang, Bojian Wu, Zhizhong Han, Yi Chang
            </div>
            <v-btn class="btn-even btn-ml  btn-mt" color="rgba(0,0,0,0)" width="130" height="40" :href="papers[4].links.paper">
              paper
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item> -->
    <!-- <v-carousel-item>
      <v-sheet color="#4582B4" height="100%">
          <img :src="imgItem[2]" class="carousel-img" id="carousel-img3">
          <div class="carousel-text-odd">
            <h1 class="carousel-text-title font-color-strong">Learning English to Chinese Character: Calligraphic Art Production based on Transformer</h1>
            <div class="carousel-text-content font-color-strong-content">Yifan Jin, Yi Zhang, Xi Yang</div>
          </div>
      </v-sheet>
    </v-carousel-item> -->
    <!-- <v-carousel-item>
      <v-sheet color="#F2F4FA" height="100%">
          <img :src="imgItem[3]" class="carousel-img" id="carousel-img4">
          <div class="carousel-text-even">
            <h1 class="carousel-text-title font-color-thin" style="font-size:28px">Fine-tuning Deep Neural Networks by Interactively Refining the 2D Latent Space of Ambiguous Images</h1>
            <div class="carousel-text-content font-color-thin">Jiafu Wei, Haoran Xie, Chia-Ming Chang, Xi Yang</div>
            <v-btn class="btn-even btn-ml btn-mt" color="rgba(0,0,0,0)" width="130" height="40" :href="papers[2].links.vedio">
            vedio
              <v-icon right>
                mdi-attachment
              </v-icon>
            </v-btn>
          </div>
      </v-sheet>
    </v-carousel-item> -->
  </v-carousel>
</template>

<style lang="css" scoped>
.font-color-strong{
  color: #4582B4;
}
.font-color-thin{
  color: #F2F4FA;
}
.font-color-strong-content{
  color: #545454;
}
.btn-mt-large{
  margin-top: 60px !important;
}
.btn-mt{
  margin-top: 20px !important;
}
.btn-ml{
  margin-left: 140px !important;
}
.btn-odd{
  color: #545454;
  border: 1px solid #545454 !important;
  box-shadow: none;
  border-radius: 0%;
  width: 90px;
}
.btn-even{
  color: #fff;
  border: 1px solid #fff !important;
  box-shadow: none;
  border-radius: 0%;
  width: 90px;
}
.carousel-text-even{
  float: right;
  margin-right: 5%;
  height: 100%;
  width: 28%;
  background-color: #4582B4;
}
.carousel-text-odd{
  float: right;
  margin-right: 5%;
  height: 100%;
  width: 28%;
  background-color: #F2F4FA;
}
.carousel-text-title{
  width: 90%;
  font-size: 30px;
  text-align: center;
  margin: auto;
  margin-top: 50px;
}
.carousel-text-content{
  font-size: 16px;
  width: 70%;
  margin: auto;
  margin-top: 20px;
  text-align: center;
}
#carousel-img1{
  max-height: 340px;
  max-width: 50%;
  margin-top: 30px;
  margin-left: 7%;
  background-color: #fff;
}
#carousel-img2{
  max-height: 340px;
  max-width: 50%;
  margin-top: 30px;
  margin-left: 7%;
}
#carousel-img3{
  max-height: 340px;
  max-width: 50%;
  margin-top: 30px;
  margin-left: 18%;
}
#carousel-img4{
  max-height: 330px;
  max-width: 55%;
  margin-top: 50px;
  margin-left: 5%;
}
</style>

<script>

// @ is an alias to /src
// import HelloWorld from '@/components/HelloWorld.vue'
export default {
  props: ['imgItem', 'papers'],
  data: () => ({
    items: [
    ],
    paperItems: [
    ]
  })
}

</script>
