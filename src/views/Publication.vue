<template>
  <v-main class="publication">
    <h1>Publications</h1>
    <v-container class="">
      <v-row>
        <v-col v-for="(paper, i) in papers" :key="i" cols="auto" md="10" >
          <v-card height="200" flat>
            <Paper :paper="paper" />
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>
<script>
import Paper from '@/components/Paper'
var aPaper = {
  title: 'IntrA: 3D Intracranial Aneurysm Dataset for Deep Learning',
  authors: '<b>Xi Yang</b>, Ding Xia, Taichi Kin, and Takeo Igarashi',
  year: '2020',
  pub: 'CVPR',
  ccf: 'A',
  image: 'https://keepthinkingyx.github.io/Xi-Yang/pic/paperfinal.jpg',
  links: {
    code: 'https://github.com/intra3d2019/IntrA',
    paper: 'https://arxiv.org/abs/2003.02920',
    data:
      'https://drive.google.com/drive/folders/1yjLdofRRqyklgwFOC0K4r7ee1LPKstPh?usp=sharing'
  }
}
var myPapers = [aPaper, aPaper, aPaper, aPaper, aPaper, aPaper, aPaper, aPaper, aPaper, aPaper, aPaper, aPaper]

export default {
  components: { Paper },
  data: () => ({
    papers: myPapers
  })
}
</script>
